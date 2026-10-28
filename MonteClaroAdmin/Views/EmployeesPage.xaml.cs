using Microsoft.Maui.Controls;
using MonteClaroAdmin.Services;
using MonteClaroAdmin.ViewModels;

namespace MonteClaroAdmin.Views;

public partial class EmployeesPage : ContentPage
{
    public EmployeesPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(new MockDataService());
    }
}
