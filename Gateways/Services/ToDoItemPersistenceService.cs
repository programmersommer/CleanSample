using Entities;
using System.Collections.Generic;
using UseCases.Interfaces;

namespace Gateways.Services
{
    internal class ToDoItemPersistenceService : IToDoItemPersistenceService
    {
        private readonly ToDoContext _context;

        public ToDoItemPersistenceService(ToDoContext context)
        {
            _context = context;
        }

        public void Save(ToDoItem item)
        {
            _context.ToDoItems.Add(item);

            _context.SaveChanges();
        }

        public IEnumerable<ToDoItem> GetToDoItems()
        {
            return _context.ToDoItems;
        }
    }
}
