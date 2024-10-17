using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Free : ISoftware
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Free(string name, string manufacturer, DateTime releaseDate)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
    }

    // Implement the DisplayInfo method
    public void DisplayInfo()
    {
        Console.WriteLine($"Free Software: {Name}, Manufacturer: {Manufacturer}, Release Date: {ReleaseDate.ToShortDateString()}");
    }

    // Free software is always usable
    public bool IsUsable()
    {
        return true;
    }
}
