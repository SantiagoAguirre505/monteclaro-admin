using MonteClaroAdmin.Models;

namespace MonteClaroAdmin.Services;

public interface IMockDataService
{
    List<StatCard> GetStats();
    List<ActivityItem> GetRecentActivity();
    List<StockProduct> GetStockProducts();
    List<RepositionItem> GetRepositionItems();
    List<InventoryProduct> GetInventory();
    List<EmployeeItem> GetEmployees();
    List<SaleItem> GetSales();
    List<ReceiptItem> GetReceipts();
}

public class MockDataService : IMockDataService
{
    public List<StatCard> GetStats() => new()
    {
        new StatCard { Title = "Productos activos", Value = "7", Subtitle = "Referencias en catálogo", Icon = "📦" },
        new StatCard { Title = "Unidades en stock", Value = "467", Subtitle = "Piezas listas para despacho", Icon = "📦" },
        new StatCard { Title = "Atención de stock", Value = "1", Subtitle = "Productos en o bajo mínimo", Icon = "⚠️" },
        new StatCard { Title = "Ventas registradas", Value = "4", Subtitle = "Movimientos en esta beta", Icon = "📋" }
    };

    public List<ActivityItem> GetRecentActivity() => new()
    {
        new ActivityItem { Title = "Ingreso · Lapacho", Location = "Maderas del Norte · AF 482 QL", Date = "27-oct", Delta = "+48 unidad", Status = "Positive" },
        new ActivityItem { Title = "Ingreso · Urunday", Location = "Maderas del Norte · PRUEBA", Date = "27-oct", Delta = "+40 unidad", Status = "Positive" },
        new ActivityItem { Title = "Venta · Tirante cepillado", Location = "Corrales El Puente", Date = "27-oct", Delta = "-18 u", Status = "Negative" },
        new ActivityItem { Title = "Venta · Tabla deck", Location = "Sudeste de Madera", Date = "27-oct", Delta = "-1 u", Status = "Negative" },
        new ActivityItem { Title = "Venta · Tabla deck", Location = "Obras del Litoral", Date = "26-oct", Delta = "-24 u", Status = "Negative" }
    };

    public List<StockProduct> GetStockProducts() => new()
    {
        new StockProduct { Product = "Listón estructural", Quantity = 3, Progress = "55", Color = "#3D6E55" },
        new StockProduct { Product = "Poste torneado", Quantity = 74, Progress = "70", Color = "#4A7A63" },
        new StockProduct { Product = "Tabla deck", Quantity = 90, Progress = "65", Color = "#6A8D72" },
        new StockProduct { Product = "Tabla machimbre", Quantity = 72, Progress = "62", Color = "#6B8D79" },
        new StockProduct { Product = "Tabla rústica", Quantity = 56, Progress = "58", Color = "#5E7F65" }
    };

    public List<RepositionItem> GetRepositionItems() => new()
    {
        new RepositionItem { Product = "Listón estructural", Species = "Guayubira", Available = 3, Minimum = 35, Status = "Revisar" }
    };

    public List<InventoryProduct> GetInventory() => new()
    {
        new InventoryProduct { Name = "Listón estructural", Category = "Madera estructural", Stock = 74, Location = "Patio 1", Price = 1800m },
        new InventoryProduct { Name = "Tabla deck", Category = "Exterior", Stock = 90, Location = "Patio 2", Price = 2400m },
        new InventoryProduct { Name = "Poste torneado", Category = "Mobiliario", Stock = 56, Location = "Patio 3", Price = 3200m },
        new InventoryProduct { Name = "Machimbre", Category = "Pisos", Stock = 32, Location = "Patio 1", Price = 1500m }
    };

    public List<EmployeeItem> GetEmployees() => new()
    {
        new EmployeeItem { Name = "Lucía Gómez", Role = "Operaria de patio", Shift = "Mañana", OnDuty = true },
        new EmployeeItem { Name = "Diego Ruiz", Role = "Supervisor", Shift = "Mañana", OnDuty = true },
        new EmployeeItem { Name = "Marta Silva", Role = "Control de stock", Shift = "Tarde", OnDuty = false },
        new EmployeeItem { Name = "Nicolás López", Role = "Carga y descarga", Shift = "Noche", OnDuty = true }
    };

    public List<SaleItem> GetSales() => new()
    {
        new SaleItem { Name = "Tabla deck", Client = "Constructora Norte", Date = "24-oct", Total = 18000m },
        new SaleItem { Name = "Listón estructural", Client = "Madera Província", Date = "25-oct", Total = 9500m },
        new SaleItem { Name = "Poste torneado", Client = "Obras del Litoral", Date = "27-oct", Total = 11250m },
        new SaleItem { Name = "Machimbre", Client = "Maderera Cañada", Date = "28-oct", Total = 7700m }
    };

    public List<ReceiptItem> GetReceipts() => new()
    {
        new ReceiptItem { Supplier = "Maderas del Norte", Product = "Lapacho", Quantity = 48, Date = "27-oct" },
        new ReceiptItem { Supplier = "Maderas Sur", Product = "Urunday", Quantity = 40, Date = "27-oct" },
        new ReceiptItem { Supplier = "Forestal del Este", Product = "Guayubira", Quantity = 24, Date = "26-oct" },
        new ReceiptItem { Supplier = "Maderera PRUEBA", Product = "Candelillo", Quantity = 18, Date = "25-oct" }
    };
}
