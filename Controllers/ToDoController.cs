using Controllers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace Controllers
{
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
