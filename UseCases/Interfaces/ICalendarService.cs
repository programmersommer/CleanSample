using System;


namespace UseCases.Interfaces
{
    public interface ICalendarService
    {
        bool DateTimeIsAvailable(DateTime date);
    }
}
