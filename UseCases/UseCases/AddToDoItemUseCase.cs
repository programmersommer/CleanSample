using Entities;
using System;
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


        public void AddToDoItem(DateTime dateTime, string description, string user)
        {
            var timeAvailable = _calendarService.DateTimeIsAvailable(dateTime);
            if (!timeAvailable)
            {
                _toDoHubService.ReturnResultToUI(user, false);
                return;
            }

            _toDoItemService.Save(new ToDoItem()
            {
                Time = dateTime,
                Description = description
            });

            _toDoHubService.ReturnResultToUI(user, true);
        }

    }
}
