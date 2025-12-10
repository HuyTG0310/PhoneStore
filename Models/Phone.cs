namespace MyBlazorProject.Models;

public class Phone
{
    public Phone(string name, int price, bool inStock)
    {
        Name = name;
        Price = price;
        InStock = inStock;
    }

    public string Name { get; set; }
    public int Price { get; set; }
    public bool InStock { get; set; }

    private readonly System.Globalization.CultureInfo vn = new System.Globalization.CultureInfo("vi-VN");

    public bool ContainsName(string SearchInput)
    {
        if (string.IsNullOrWhiteSpace(SearchInput))
        {
            return true;
        }
        return Name?.IndexOf(SearchInput.Trim(), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public bool IsValidPrice(string PriceInput)
    {

        if (PriceInput.Equals("1"))
        {
            return Price >= 5000000 && Price <= 10000000;
        }
        if (PriceInput.Equals("2"))
        {
            return Price >= 10000000 && Price <= 20000000;
        }
        if (PriceInput.Equals("3"))
        {
            return Price >= 20000000 && Price <= 45000000;
        }
        return true;
    }

    public bool IsValidInStock(bool InStockInput)
    {
        if (InStockInput)
        {
            return InStock;
        }
        return true;
    }

    public bool IsFiltered(string SearchInput, string PriceInput, bool InStockInput)
    {
        return ContainsName(SearchInput) && IsValidPrice(PriceInput) && IsValidInStock(InStockInput);
    }

    public string FormatMoney()
    {
        return Price.ToString("C", vn);
    }

    public string getBrand()
    {
        if (Name.StartsWith("Iphone", StringComparison.OrdinalIgnoreCase))
        {
            return "Iphone";
        }
        if (Name.StartsWith("Samsung", StringComparison.OrdinalIgnoreCase))
        {
            return "Samsung";
        }
        return "Xiaomi";
    }

    public string getBrandClass()
    {
        switch (getBrand())
        {
            case "Iphone":
                return "badge bg-danger";
            case "Samsung":
                return "badge bg-primary";
            case "Xiaomi":
                return "badge bg-warning";
            default:
                return "";
        }
    }
}