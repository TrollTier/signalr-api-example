using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRApi.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, Customer customer = null)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}
