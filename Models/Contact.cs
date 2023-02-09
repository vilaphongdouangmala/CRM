using System.ComponentModel.DataAnnotations;

public class Contact {
  [Key]
  public int ContactId {get;set;}//pk label="Contacts"
  public DateTime CreatedDate {get;set;}//label="Created_date"
  public String FirstName {get;set;}//label="First_name"
  public String LastName {get;set;}//label="Last_name"
  public String Email {get;set;}//label="Email"
  public int PhoneNumber {get;set;}//label="Phone_number"
  public DateTime Birthdate {get;set;}//label="Birthdate"
  public DateTime ModifiedDate {get;set;}//label="Modified_date"
  public DateTime LastContactedDate {get;set;}//label="Last_contacted_date"
  public int AccountId {get;set;}//fk="Account"
  public Account Account {get;set;} //np
  public int OpportunityId {get;set;}//fk="Opportunity"
  public Opportunity Opportunity {get;set;} //np

}//ec

