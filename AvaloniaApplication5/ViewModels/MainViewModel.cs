using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication5.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _buttonText = "Another Button";

    private int _clickCount = 0;

    [RelayCommand]
    public void ButtonClick()
    {
        ButtonText = $"Clicked {++_clickCount}";
    }
}
