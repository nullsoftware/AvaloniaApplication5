using Avalonia.Controls;

namespace AvaloniaApplication5.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        btn.Content = "You clicked on button";
    }

}
