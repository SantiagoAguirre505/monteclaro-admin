using MonteClaroAdmin.Models;
using MonteClaroAdmin.Services;

namespace MonteClaroAdmin.ViewModels;

public class DashboardViewModel
{
    public List<StatCard> Stats { get; set; }
    public List<ActivityItem> RecentActivity { get; set; }
    public List<StockProduct> StockProducts { get; set; }
    public List<RepositionItem> RepositionItems { get; set; }
    public List<InventoryProduct> Inventory { get; set; }
    public List<EmployeeItem> Employees { get; set; }
    public List<SaleItem> Sales { get; set; }
    public List<ReceiptItem> Receipts { get; set; }

    public DashboardViewModel(IMockDataService mockDataService)
    {
        Stats = mockDataService.GetStats();
        RecentActivity = mockDataService.GetRecentActivity();
        StockProducts = mockDataService.GetStockProducts();
        RepositionItems = mockDataService.GetRepositionItems();
        Inventory = mockDataService.GetInventory();
        Employees = mockDataService.GetEmployees();
        Sales = mockDataService.GetSales();
        Receipts = mockDataService.GetReceipts();
    }
}
