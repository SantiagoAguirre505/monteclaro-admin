using Microsoft.Maui.Controls;
using MonteClaroAdmin.Services;
using MonteClaroAdmin.ViewModels;

namespace MonteClaroAdmin.Views;

public partial class InventoryPage : ContentPage
{
    public InventoryPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(new MockDataService());
    }
}
