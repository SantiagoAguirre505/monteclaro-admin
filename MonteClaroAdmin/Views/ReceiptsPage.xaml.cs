using Microsoft.Maui.Controls;
using MonteClaroAdmin.Services;
using MonteClaroAdmin.ViewModels;

namespace MonteClaroAdmin.Views;

public partial class ReceiptsPage : ContentPage
{
    public ReceiptsPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(new MockDataService());
    }
}
