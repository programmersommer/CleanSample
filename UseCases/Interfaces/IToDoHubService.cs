using System.Threading.Tasks;


namespace UseCases.Interfaces
{
    public interface IToDoHubService
    {
        Task ReturnResultToUI(string user, bool result);
    }
}
