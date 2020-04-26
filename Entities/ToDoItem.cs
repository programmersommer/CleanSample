using System;


namespace Entities
{
    // Inside entities we can have public methods
    // Entity = smart object
	// Fields could be in DDD-style with private set 
    public class ToDoItem
    {
        public DateTime Time { get; set; }
        public string Description { get; set; }
    }
}
