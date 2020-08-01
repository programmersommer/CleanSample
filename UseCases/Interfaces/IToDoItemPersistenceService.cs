using Entities;
using System;
using System.Collections.Generic;

namespace UseCases.Interfaces
{
    public interface IToDoItemPersistenceService
    {
        void Save(ToDoItem item);
        IEnumerable<ToDoItem> GetToDoItems();
        ToDoItem GetToDoItem(DateTime eventDateTime);
    }
}
