using Controllers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace Controllers
{
    // Do you know that class could be not inherited from Controller?
    // By convention if class ends with "Controller" it is recognized as controller
    // Just FYI. Of course better inherit API from BaseController 
    public class ToDoController 
    {
        private readonly IAddToDoItemUseCase _addToDoItemUseCase;

        public ToDoController(IAddToDoItemUseCase addToDoItemUseCase)
        {
            _addToDoItemUseCase = addToDoItemUseCase;
        }

        [ValidateAntiForgeryToken]
        public async Task AddToDo(HomeViewModel model)
        {
            await _addToDoItemUseCase.AddToDoItemAsync(model.Time, model.Description, model.User);
        }

    }
}
