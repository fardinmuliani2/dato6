using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Trial : ISoftware
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime InstallDate { get; set; }
    public int TrialPeriodMonths { get; set; }

    public Trial(string name, string manufacturer, DateTime releaseDate, DateTime installDate, int trialPeriodMonths)
    {
        Name = name;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
        InstallDate = installDate;
        TrialPeriodMonths = trialPeriodMonths;
    }

    // Implement the DisplayInfo method
    public void DisplayInfo()
    {
        Console.WriteLine($"Trial Software: {Name}, Manufacturer: {Manufacturer}, Release Date: {ReleaseDate.ToShortDateString()}, " +
                          $"Install Date: {InstallDate.ToShortDateString()}, Trial Period: {TrialPeriodMonths} months");
    }

    // Check if the trial period is still valid
    public bool IsUsable()
    {
        DateTime expirationDate = InstallDate.AddMonths(TrialPeriodMonths);
        return DateTime.Now < expirationDate;
    }
}
