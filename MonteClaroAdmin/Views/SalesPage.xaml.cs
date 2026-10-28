using Microsoft.Maui.Controls;
using MonteClaroAdmin.Services;
using MonteClaroAdmin.ViewModels;

namespace MonteClaroAdmin.Views;

public partial class SalesPage : ContentPage
{
    public SalesPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(new MockDataService());
    }
}
