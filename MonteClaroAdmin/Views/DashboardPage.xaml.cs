using Microsoft.Maui.Controls;
using MonteClaroAdmin.Services;
using MonteClaroAdmin.ViewModels;

namespace MonteClaroAdmin.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(new MockDataService());
    }
}
