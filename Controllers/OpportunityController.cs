using Microsoft.AspNetCore.Mvc;


public class OpportunityController : Controller
{
    private readonly ILogger<OpportunityController> _logger;

    public OpportunityController(ILogger<OpportunityController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    #region ACTIONS

    #endregion

}//ec
