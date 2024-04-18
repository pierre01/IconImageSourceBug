using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace IconImageSourceBug.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    public ObservableCollection<TodoItem> ActiveTodos { get; set; }

    public MainPageViewModel()
    {
        ActiveTodos = [
            new TodoItem { Title = "Buy milk" },
            new TodoItem { Title = "Buy bread" },

            new TodoItem { Title = "Buy eggs", IsDone = true }
        ];
    }

    [RelayCommand]
    private void DoSomething(object param)
    {
        var todo = param as TodoItem;
        if (todo != null)
        {
            // Needed to refresh the item and show that the original color was modified
            todo.IsDone = !todo.IsDone;
        }
    }
}
