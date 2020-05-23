using System;
using System.Threading.Tasks;

namespace UseCases.Interfaces
{
    public interface IAddToDoItemUseCase
    {
        Task AddToDoItemAsync(DateTime dateTime, string description, string user);
    }
}
