using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[action]")]
public class ApiController : ControllerBase
{
    private readonly ILogger<ApiController> _logger;
    private CrmDbContext _db;

    //!!!REMOVE WHEN IMPLEMENT DATABASE
    public static List<Opportunity> opportunities = new List<Opportunity>();

    public ApiController(ILogger<ApiController> logger, CrmDbContext db)
    {
        _logger = logger;
        _db = db;
    }


    #region ACTIONS

    #region Opportunity

    [HttpGet]
    public IActionResult GetAllOpportunities()
    {
        //!!!change it to database format after
        return Ok(opportunities);
    }//ef
    
    #endregion


    #region Quote
    
    [HttpPost]
    public IActionResult AddQuote(Quote quote) {
        return Ok();
    }//ef

    [HttpGet]
    public IActionResult GetNewQuoteSelections() {
        var statuses = _db.QuoteStatus.ToList();
        return Ok(new {
            statuses
        });
    }//ef

    #endregion


    #region Statuses

    [HttpPost]
    public IActionResult AddLeadStatus(LeadStatus status) {
        _db.Add(status);
        _db.SaveChanges();
        return Ok(status);
    }//ef

    [HttpPost]
    public IActionResult AddOpportunityStatus(OpportunityStatus status) {
        _db.Add(status);
        _db.SaveChanges();
        return Ok(status);
    }//ef

    [HttpPost]
    public IActionResult AddQuoteStatus(QuoteStatus status) {
        _db.Add(status);
        _db.SaveChanges();
        return Ok(status);
    }//ef

    #endregion

    #endregion

}//ec
