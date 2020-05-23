using Microsoft.AspNetCore.SignalR;
using Presenters.Hubs;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace Presenters.Services.Services
{
    internal class ToDoHubService : IToDoHubService
    {
        private readonly IHubContext<ToDoHub> _hubContext;

        public ToDoHubService(IHubContext<ToDoHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task ReturnResultToUIAsync(string user, bool result)
        {
            // we can handle/transform result here
            // for example we can return HTML
            await _hubContext.Clients.Client(user).SendAsync("ToDoResult", result).ConfigureAwait(false);
        }
    }
}
