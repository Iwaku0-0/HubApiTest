using MessagePack;
using MessagePack.Resolvers;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace HubApiTest
{
    internal class Program
    {
        static async Task<object> HubFunction(HubConnection hub, string func, params string[] args)
        {
            if (args.Length == 0)
            {
                return await hub.InvokeAsync<object>(func);
            }
            else
            {
                return await hub.InvokeCoreAsync<object>(func, args);
            }
        }
        static void Main()
        {
            HubConnection hub = new HubConnectionBuilder().AddMessagePackProtocol(delegate (MessagePackHubProtocolOptions options)
            {
                options.SerializerOptions =
                MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block)
                .WithResolver(ContractlessStandardResolver.Instance);
            }
            ).WithUrl("https://stepfordcountyrailway.co.uk/Push/Meta")
            .Build();

            hub.StartAsync().Wait();

            while (true)
            {
                try
                {
                    string? cmd = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(cmd)) continue;
                    string[] split = cmd.Split(' ');

                    object result = HubFunction(hub, split[0], split.Skip(1).ToArray()).GetAwaiter().GetResult();

                    Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured while processing command!");
                    Console.WriteLine(ex.ToString());
                    continue;
                }
            }
        }
    }
}