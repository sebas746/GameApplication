using GamingAppBackEnd.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamingAppBackEnd.SignalR
{
    public class SignalRHub : Hub
    {
        // required to let the Hub to be called from other server-side classes/controllers, using static methods
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();

        // Send the data to all clients (may be called from client JS - hub.client.broadcastCommonData)
        public void BroadcastCommonData(string data)
        {
            Clients.All.BroadcastCommonData(data);
        }

        // Send the data to all clients (may be called from server C#)
        // In this example, called by TestController on data update (see the Post method)
        public void BroadcastCommonDataStatic(string data)
        {
            hubContext.Clients.All.BroadcastCommonData(data);
        }

        public void BroadcastPlayer(string player)
        {
            hubContext.Clients.All.BroadcastCommonData(player);
        }
    }
}