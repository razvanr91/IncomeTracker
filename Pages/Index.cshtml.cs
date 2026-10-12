using IncomeTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IncomeTracker.Pages;

public class IndexModel : PageModel
{
    public string Name { get; set; }
    public Income Income { get; set; }
    public void OnGet()
    {
        Name = "Razvan";
        Income = new Income("Salary", "GXO Logistics", 4129m, DateOnly.FromDateTime(DateTime.Now),
            Frequency.Monthly);
    }
}