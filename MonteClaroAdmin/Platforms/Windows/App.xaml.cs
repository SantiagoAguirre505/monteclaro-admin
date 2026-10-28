using Microsoft.UI.Xaml;

namespace MonteClaroAdmin;

public partial class App : Application
{
    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        var window = new Window();
        window.Activate();
    }
}
