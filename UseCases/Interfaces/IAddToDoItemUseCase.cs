using System;


namespace UseCases.Interfaces
{
    public interface IAddToDoItemUseCase
    {
        void AddToDoItem(DateTime dateTime, string description, string user);
    }
}
