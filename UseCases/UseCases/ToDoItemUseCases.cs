using Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.UseCases
{
    // Iteractor
    public class ToDoItemUseCases : IToDoItemUseCases
    {
        private readonly ICalendarService _calendarService;
        private readonly IToDoItemPersistenceService _toDoItemService;
        private readonly IToDoHubService _toDoHubService;

        public ToDoItemUseCases(ICalendarService calendarService,
            IToDoItemPersistenceService toDoItemService, IToDoHubService toDoHubService)
        {
            _calendarService = calendarService;
            _toDoItemService = toDoItemService;
            _toDoHubService = toDoHubService;
        }

        public async Task AddToDoItemAsync(DateTime dateTime, string description, string user)
        {
            var timeAvailable = _calendarService.DateTimeIsAvailable(dateTime);
            if (!timeAvailable)
            {
                await _toDoHubService.ReturnResultToUIAsync(user, false, "Time is not available").ConfigureAwait(false);
                return;
            }

            try
            {
                _toDoItemService.Save(new ToDoItem(dateTime, description));
            }
            catch (Exception e)
            {
                await _toDoHubService.ReturnResultToUIAsync(user, false, e.Message).ConfigureAwait(false);
                return;
            }

            await GetToDoItemsAsync(user);
        }

        public async Task GetToDoItemsAsync(string user)
        {
            var items = _toDoItemService.GetToDoItems().ToList();

            await _toDoHubService.ReturnResultToUIAsync(user, items).ConfigureAwait(false);
        }
    }
}
