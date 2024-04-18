using CommunityToolkit.Mvvm.ComponentModel;

namespace IconImageSourceBug;

public partial class TodoItem : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private bool _isDone;
}