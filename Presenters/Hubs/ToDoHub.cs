using Microsoft.AspNetCore.SignalR;


namespace Presenters.Hubs
{
    public class ToDoHub : Hub
    {
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}
