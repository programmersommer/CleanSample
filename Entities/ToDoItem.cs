using System;

namespace Entities
{
    // Inside entities we can have public methods - validations, calculations, business rules etc.
    // Entity = smart object
    // Fields could be in DDD-style with private set 
    public class ToDoItem
    {
        public int Id { get; set; }
        public DateTime EventDateTime { get; private set; }
        public string Description { get; private set; }

        public ToDoItem(DateTime eventDateTime, string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException($"{nameof(Description)} should not be empty");
            }

            if (eventDateTime < DateTime.UtcNow)
            {
                throw new ArgumentOutOfRangeException($"{nameof(EventDateTime)} should be beyond current UTC time");
            }

            EventDateTime = eventDateTime;
            Description = description;
        }
    }
}
