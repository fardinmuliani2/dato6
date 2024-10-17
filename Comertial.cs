using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Commercial : ISoftware
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime ReleaseDate { get; set; }
    public double Price { get; set; }
    public DateTime InstallDate { get; set; }
    public int ExpirationMonths { get; set; }

    public Commercial(string name, string manufacturer, DateTime releaseDate, double price, DateTime installDate, int expirationMonths)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
        Price = price;
        InstallDate = installDate;
        ExpirationMonths = expirationMonths;
    }

    // Implement the DisplayInfo method
    public void DisplayInfo()
    {
        Console.WriteLine($"Commercial Software: {Name}, Manufacturer: {Manufacturer}, Release Date: {ReleaseDate.ToShortDateString()}, " +
                          $"Price: {Price}, Install Date: {InstallDate.ToShortDateString()}, Expiration Period: {ExpirationMonths} months");
    }

    // Check if the software is still within the expiration period
    public bool IsUsable()
    {
        DateTime expirationDate = InstallDate.AddMonths(ExpirationMonths);
        return DateTime.Now < expirationDate;
    }
}
