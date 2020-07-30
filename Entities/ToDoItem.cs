using System;
using System.Collections.Generic;

namespace Entities
{
    // Inside entities we can have public methods - validations, calculations, business rules etc.
    // Entity = smart object
    // Fields could be in DDD-style with private set 
    public class ToDoItem : ValueObject
    {
        public int Id { get; set; }
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

        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return Time;
            yield return Description;
        }
    }
}
