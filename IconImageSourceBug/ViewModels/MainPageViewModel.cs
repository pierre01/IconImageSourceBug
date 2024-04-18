using System.Collections.ObjectModel;

namespace IconImageSourceBug.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<TodoItem> ActiveTodos { get; set; }
    public ObservableCollection<TodoItem> CompletedTodos { get; set; }

    public MainPageViewModel()
    {
        ActiveTodos = [
            new TodoItem { Name = "Buy milk" },
            new TodoItem { Name = "Buy bread" }
        ];
        CompletedTodos = [
            new TodoItem { Name = "Buy eggs", IsDone = true }
        ];
    }
}
