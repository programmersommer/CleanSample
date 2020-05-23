using Entities;
using System;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.UseCases
{
    // Iteractor
    public class AddToDoItemUseCase : IAddToDoItemUseCase
    {
        private readonly ICalendarService _calendarService;
        private readonly IToDoItemPersistenceService _toDoItemService;
        private readonly IToDoHubService _toDoHubService;

        public AddToDoItemUseCase(ICalendarService calendarService,
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
                await _toDoHubService.ReturnResultToUIAsync(user, false).ConfigureAwait(false);
                return;
            }

            _toDoItemService.Save(new ToDoItem()
            {
                Time = dateTime,
                Description = description
            });

            await _toDoHubService.ReturnResultToUIAsync(user, true).ConfigureAwait(false);
        }

    }
}
