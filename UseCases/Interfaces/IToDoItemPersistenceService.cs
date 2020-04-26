using Entities;
using System;


namespace UseCases.Interfaces
{
    public interface IToDoItemPersistenceService
    {
        void Save(ToDoItem item);
    }
}
