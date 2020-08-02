using Entities;
using System.Collections.Generic;

namespace Presenters.ViewModels
{
    class ToDoItemViewModel
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public List<ToDoItem> Items { get; set; }
    }
}
