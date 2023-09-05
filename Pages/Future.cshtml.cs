using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperWeb.model;

namespace SuperWeb.Pages;

public class FutureModel : PageModel
{
    public decimal MonthlyInvestment { get; set; }
    public decimal YearlyInterestRate { get; set; }
    public int Years { get; set; }

    private readonly ILogger<FutureModel> _logger;

    public FutureModel(ILogger<FutureModel> logger)
    {
        _logger = logger;
    }

    

    public void OnGet()
    {
        ViewData["FV"] = 0;
    }

    public void OnPost(FutureValue model)
        {
            ViewData["FV"] = model.CalculateFutureValue();
        }
}

