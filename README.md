# HubApiTest

``` cs
	public async Task<HeadlineStatisticsViewModel> GetHeadlineStatistics()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<HeadlineStatisticsViewModel>("GetHeadlineStatistics");
	}

	public async Task<LiveActivitiesViewModel?> GetLiveActivitiesByServer(Guid id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<LiveActivitiesViewModel>("GetLiveActivitiesByServer", id);
	}

	public async Task<StationLiveActivitiesViewModel?> GetLiveActivitiesByServerAndStation(Guid serverId, string stationId)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<StationLiveActivitiesViewModel>("GetLiveActivitiesByServerAndStation", serverId, stationId);
	}

	public async Task<ServersViewModel?> GetOnlineServers()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<ServersViewModel>("GetOnlineServers");
	}

	public async Task<PlayerViewModel?> GetPlayer(long id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<PlayerViewModel>("GetPlayer", id);
	}

	public async Task<PlayerCurrentActivityViewModel?> GetPlayerCurrentActivity(long id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<PlayerCurrentActivityViewModel>("GetPlayerCurrentActivity", id);
	}

	public async Task<PlayerDetailsViewModel?> GetPlayerDetails(long id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<PlayerDetailsViewModel>("GetPlayerDetails", id);
	}

	public async Task<RoleTaskViewModel?> GetRoleTask(Guid id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<RoleTaskViewModel>("GetRoleTask", id);
	}

	public async Task<ServerDetailsViewModel?> GetServer(Guid id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<ServerDetailsViewModel>("GetServer", id);
	}

	public async Task<PlayersViewModel?> SearchPlayers(string searchTerm)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<PlayersViewModel>("SearchPlayers", searchTerm);
	}

	public async Task<FrequentlyAskedQuestionsViewModel> GetFrequentlyAskedQuestions()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<FrequentlyAskedQuestionsViewModel>("GetFrequentlyAskedQuestions");
	}

	public async Task<PushEndpointViewModel> GetPushEndpoint()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<PushEndpointViewModel>("GetPushEndpoint");
	}

	public async Task<ServiceStatusViewModel> GetServiceStatus()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<ServiceStatusViewModel>("GetServiceStatus");
	}

	public async Task<HubUserPreferencesViewModel> GetUserPreferences()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<HubUserPreferencesViewModel>("GetUserPreferences");
	}

	public async Task SetUserWhenLastSeenOnHubSite(WhenLastSeenUpdateRequestModel whenLastSeenUpdateRequestModel)
	{
		await StartIfNotStarted();
		await _signalRClientService.GetHubConnection().InvokeAsync<WhenLastSeenUpdateRequestModel>("WhenLastSeenUpdateRequestModel");
	}

	public async Task<HubUserPreferencesViewModel> UpdateUserPreferences(HubUserPreferencesViewModel preferences)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<HubUserPreferencesViewModel>("UpdateUserPreferences", preferences);
	}

	public async Task<string> GetEventsForPlayer(long playerId)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<string>("GetEventsForPlayer", playerId);
	}

	public async Task<string> GetEventsForServer(Guid serverId)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<string>("GetEventsForServer", serverId);
	}

	public async Task<UnresolvedRoleTasksViewModel?> GetUnresolvedRoleTasks()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<UnresolvedRoleTasksViewModel>("GetUnresolvedRoleTasks");
	}

	public async Task<PlayersLastSeenViewModel?> GetUsersLastSeenOnHubSiteSince(DateTimeOffset? whenLastSeen)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<PlayersLastSeenViewModel>("GetUsersLastSeenOnHubSiteSince", whenLastSeen);
	}

	public async Task<string> GetVersion()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<string>("GetVersion");
	}

	public async Task SetServiceStatus(ServiceStatusViewModel newServiceStatus)
	{
		await StartIfNotStarted();
		await _signalRClientService.GetHubConnection().InvokeAsync<ServiceStatusViewModel>("SetServiceStatus", newServiceStatus);
	}

	public async Task TotalRelearn()
	{
		await StartIfNotStarted();
		await _signalRClientService.GetHubConnection().InvokeAsync("TotalRelearn");
	}

	public async Task<WorldStatisticsViewModel?> GetAllStatistics()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<WorldStatisticsViewModel>("GetAllStatistics");
	}

	public async Task<OperatingCompanyStatisticsViewModel?> GetOperatingCompanyStatistics(string id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<OperatingCompanyStatisticsViewModel>("GetOperatingCompanyStatistics", id);
	}

	public async Task<RouteStatisticsViewModel?> GetRouteStatistics(string id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<RouteStatisticsViewModel>("GetRouteStatistics", id);
	}

	public async Task<StationStatisticsViewModel?> GetStationStatistics(string id)
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<StationStatisticsViewModel>("GetStationStatistics", id);
	}

	public async Task<WorldViewModel> GetWorldViewModel()
	{
		await StartIfNotStarted();
		return await _signalRClientService.GetHubConnection().InvokeAsync<WorldViewModel>("GetWorldViewModel");
	}
```