using Entities;
using Microsoft.AspNetCore.SignalR;
using Presenters.Hubs;
using Presenters.ViewModels;
using System.Collections.Generic;
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

        // we can handle/transform result here - pack into ViewModel

        public async Task ReturnResultToUIAsync(string user, bool result, string message = "")
        {
            var model = new ToDoItemViewModel()
            {
                Result = result,
                Message = message
            };
            await _hubContext.Clients.Client(user).SendAsync("ToDoResult", model).ConfigureAwait(false);
        }

        public async Task ReturnResultToUIAsync(string user, List<ToDoItem> items)
        {
            var model = new ToDoItemViewModel()
            {
                Result = true,
                Items = items
            };
            await _hubContext.Clients.Client(user).SendAsync("ToDoResult", model).ConfigureAwait(false);
        }
    }
}
