using System;
using UseCases.Interfaces;

namespace UseCases.Services
{
    public class CalendarService : ICalendarService
    {
        public bool DateTimeIsAvailable(DateTime date)
        {
            // some logic checks do some event is already planned for specified day and time
            return true;
        }
    }
}
