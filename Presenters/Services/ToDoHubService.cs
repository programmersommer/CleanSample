using Microsoft.AspNetCore.SignalR;
using Presenters.Hubs;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace Presenters.Services.Services
{
    public class ToDoHubService : IToDoHubService
    {
        IHubContext<ToDoHub> _hubContext;

        public ToDoHubService(IHubContext<ToDoHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task ReturnResultToUI(string user, bool result)
        {
            // we can handle/transform result here
            // for example we can return HTML
            await _hubContext.Clients.Client(user).SendAsync("ToDoResult", result);
        }
    }
}
