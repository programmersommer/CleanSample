using Entities;
using UseCases.Interfaces;

namespace Gateways.Services
{
    public class ToDoItemPersistenceService : IToDoItemPersistenceService
    {
        public void Save(ToDoItem item)
        {
            // logic that saves ToDoItem to database
        }
    }
}
