using System;

namespace OpenHAB.NetRestApi.RestApi
{
    public static class OpenHab
    {
        #region Rest Client

        /// <summary>
        /// Creates the rest client and connects to an open server with the port 8080
        /// </summary>
        /// <param name="serverName">Name of the server.</param>
        /// <param name="startEventService">if set to <c>true</c> [start event service].</param>
        /// <returns></returns>
        public static OpenHabRestClient CreateRestClient(string serverName, bool startEventService = false)
        {
            var restUrl = $"http://{serverName}:8080/rest";
            return CreateRestClient(new Uri(restUrl), null, null, startEventService);
        }

        public static OpenHabRestClient CreateRestClient(Uri uri, bool startEventService = false)
        {
            return CreateRestClient(uri, null, null, startEventService);
        }

        public static OpenHabRestClient CreateRestClient(Uri uri, string username, string password, bool startEventService = false)
        {
            OpenHabRestClient restClient;
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                restClient = new OpenHabRestClient(uri.ToString());
            } else
            {
                restClient = new OpenHabRestClient(uri, username, password);
            }
            if (startEventService) restClient.EventService.InitializeAsync();
            return RestClient = restClient;
        }

        internal static OpenHabRestClient RestClient { get; private set; }

        #endregion
    }
}