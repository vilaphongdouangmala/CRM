using System.ComponentModel.DataAnnotations;

public class Opportunity {
  [Key]
  public int OpportunityId {get;set;}//pk label="Opportunity"
  public DateTime CreatedDate {get;set;}//label="Created_date"
  public String OpportunityName {get;set;}//label="Opportunity_name"
  public double Amount {get;set;}//label="Amount"
  public DateTime ModifiedDate {get;set;}//label="Modified_date"
  public int OpportunityStatusId {get;set;}//fk="OpportunityStatus"
  public OpportunityStatus OpportunityStatus {get;set;} //np
  public String Note {get;set;}//label="Note"
  public int QuoteId {get;set;}//fk="Quote"
  public Quote Quote {get;set;} //np
  public int AccountId {get;set;}//fk="Account"
  public Account Account {get;set;} //np
  public List<Contact> Contacts {get;set;}
//label="Contacts"

}//ec

