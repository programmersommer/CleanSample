using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace UseCases.Interfaces
{
    public interface IToDoHubService
    {
        Task ReturnResultToUIAsync(string user, bool result, string message = "");
        Task ReturnResultToUIAsync(string user, List<ToDoItem> items);
    }
}
