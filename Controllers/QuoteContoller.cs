using Microsoft.AspNetCore.Mvc;


public class QuoteController : Controller
{
    private readonly ILogger<QuoteController> _logger;

    public QuoteController(ILogger<QuoteController> logger)
    {
        _logger = logger;
    }

    #region ACTIONS
    public IActionResult Index()
    {
        return View();
    }//ef

    public IActionResult AddQuote()
    {
        return View();
    }//ef
    #endregion

}//ec
