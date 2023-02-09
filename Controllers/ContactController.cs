using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller {

    public static List<Contact> contacts = new List<Contact>();
    public static Contact newContact = null;
    
    public static int newContactId = 1;
    
    public IActionResult Index() {
        return View();
    }//ef

    [HttpGet]
    public IActionResult getAllContacts() {
        return Ok(contacts);
    }//ef

    [HttpPost] //might need to be modified
    public IActionResult updateContact([FromBody] Contact contact) {
        Contact foundContact = contacts.First(x => x.ContactId == contact.ContactId);
        int foundIndex = contacts.IndexOf(foundContact);
        if (foundContact == null) {
            return Ok(new {
                success = -1,
                msg = "Update Failed"
            });
        }
        //1. set modification date
        contact.ModifiedDate = DateTime.Now;
        //2. update contact
        contacts[foundIndex] = contact;
        return Ok(new {
            success = 1,
            msg = "Updated Successfully",
            obj = contacts[foundIndex]
        });
    }//ef
}//ec