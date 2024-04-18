using CommunityToolkit.Mvvm.ComponentModel;

namespace IconImageSourceBug;

public partial class TodoItem : ObservableObject
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    [NotifyPropertyChangedFor("IsNotDone")]
    private bool _isDone;

    public bool IsNotDone => !IsDone;
}