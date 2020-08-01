using System;
using UseCases.Interfaces;

namespace UseCases.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly IToDoItemPersistenceService _toDoItemService;

        public CalendarService(IToDoItemPersistenceService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        public bool DateTimeIsAvailable(DateTime dateAvailable)
        {
            var todoItem = _toDoItemService.GetToDoItem(dateAvailable);
            return (todoItem == default);
        }
    }
}
