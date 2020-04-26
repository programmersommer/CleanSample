using Controllers.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
        public void AddToDo(HomeViewModel model)
        {
            _addToDoItemUseCase.AddToDoItem(model.Time, model.Description, model.User);
        }

    }
}
