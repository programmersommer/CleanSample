using System;
using System.Threading.Tasks;

namespace UseCases.Interfaces
{
    public interface IToDoItemUseCases
    {
        Task AddToDoItemAsync(DateTime dateTime, string description, string user);
        Task GetToDoItemsAsync(string user);
    }
}
