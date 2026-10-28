namespace MonteClaroAdmin.Models;

public class StatCard
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Icon { get; set; } = "📦";
}

public class ActivityItem
{
    public string Title { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string Delta { get; set; } = string.Empty;
    public string Status { get; set; } = "Positive";
}

public class StockProduct
{
    public string Product { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Progress { get; set; } = "50";
    public string Color { get; set; } = "#7BAA8E";
}

public class RepositionItem
{
    public string Product { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;
    public int Available { get; set; }
    public int Minimum { get; set; }
    public string Status { get; set; } = "OK";
}

public class InventoryProduct
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Stock { get; set; }
    public string Location { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class EmployeeItem
{
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Shift { get; set; } = string.Empty;
    public bool OnDuty { get; set; }
}

public class SaleItem
{
    public string Name { get; set; } = string.Empty;
    public string Client { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public decimal Total { get; set; }
}

public class ReceiptItem
{
    public string Supplier { get; set; } = string.Empty;
    public string Product { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Date { get; set; } = string.Empty;
}
