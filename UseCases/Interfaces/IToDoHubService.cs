using System.Threading.Tasks;


namespace UseCases.Interfaces
{
    public interface IToDoHubService
    {
        Task ReturnResultToUIAsync(string user, bool result);
    }
}
