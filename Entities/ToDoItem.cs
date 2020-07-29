using System;


namespace Entities
{
    // Inside entities we can have public methods - validations, calculations, business rules etc.
    // Entity = smart object
    // Fields could be in DDD-style with private set 
    public class ToDoItem
    {
        public DateTime Time { get; private set; }
        public string Description { get; private set; }

        public ToDoItem(DateTime time, string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException($"{nameof(Description)} should not be empty");
            }

            if (time < DateTime.UtcNow)
            {
                throw new ArgumentOutOfRangeException($"{nameof(Time)} should be beyond current UTC time");
            }

            Time = time;
            Description = description;
        }
    }
}
