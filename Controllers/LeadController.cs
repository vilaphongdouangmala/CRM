using Microsoft.AspNetCore.Mvc;

public class LeadController : Controller {
    public static List<Lead> leads = new List<Lead>() {
        new Lead {
            LeadId = 101,
            FirstName = "Cannon",
            LastName = "Jett",
            Email = "cannon123@gmail.com",
            CreatedDate = DateTime.Now,
            Source = "Website"
        },
        new Lead {
            LeadId = 102,
            FirstName = "Astrid",
            LastName = "Camellia",
            Email = "Astrid123@gmail.com",
            CreatedDate = DateTime.Now,
            Source = "Website"
        },
        new Lead {
            LeadId = 103,
            FirstName = "Alden",
            LastName = "Zoey",
            Email = "Alden123@gmail.com",
            CreatedDate = DateTime.Now,
            Source = "Website"
        },
        new Lead {
            LeadId = 104,
            FirstName = "Curtis",
            LastName = "Campbell",
            Email = "campbell555@gmail.com",
            CreatedDate = DateTime.Now,
            Source = "Website"
        },
        new Lead {
            LeadId = 105,
            FirstName = "Mila",
            LastName = "Medina",
            Email = "medina123@gmail.com",
            CreatedDate = DateTime.Now,
            Source = "Website"
        },
        new Lead {
            LeadId = 106,
            FirstName = "Vincent",
            LastName = "Moyer",
            Email = "moyer478@gmail.com",
            CreatedDate = DateTime.Now,
            Source = "Website"
        }
    };

    //count LeadId
    static int newLeadId = 101;
    public static Lead selectedLead = null;

    public IActionResult Index() {
        return View();
    }//ef

    [HttpGet]
    public IActionResult getAllLeads() {
        var result = leads;
        return Ok(result);
    }//ef 

    [HttpPost]
    public IActionResult addLead([FromBody] Lead lead) {
        newLeadId += 1;
        lead.LeadId = newLeadId;
        lead.CreatedDate = DateTime.Now;
        leads.Add(lead);
        return Ok(leads);
    }//ef

    public IActionResult details() {
        return View("Details");
    }//ef

    [HttpPost]
    public IActionResult selectLead([FromBody] Lead lead) {
        selectedLead = lead;
        return Ok(selectedLead);
    }//ef

    [HttpGet]
    public IActionResult getSelectedLead() {
        return Ok(selectedLead);
    }//ef

    public IActionResult convertLeadToContact() {
        ContactController.newContactId += 1;
        Contact newContact = new Contact {
            ContactId = ContactController.newContactId, // need to be removed
            CreatedDate = DateTime.Now,
            FirstName = selectedLead.FirstName,
            LastName = selectedLead.LastName,
            Email = selectedLead.Email,
            ModifiedDate = DateTime.Now,
            LastContactedDate = DateTime.Now
        };
        ContactController.contacts.Add(newContact);
        return Ok(new {
            success = 1,
            msg = "Converted Successfully"
        });
    }//ef

    [HttpPost]
    public IActionResult convertLeadToOpportunity(DtoOpportunity o) {
        Opportunity newOpportunity = new Opportunity {
            OpportunityId = 1,
            // OpportunityName = opportunityName,
            OpportunityStatus = new OpportunityStatus {
                StatusName = "Not started"
            },
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };
        //temporary
        ApiController.opportunities.Add(newOpportunity);
        // return Ok(new {
        //     success = 1,
        //     msg = "Converted Successfully"
        // });
        return Ok(new {
            msg = o.OpportunityName,
            status = "1"
        });
    }//ef
}//ec
