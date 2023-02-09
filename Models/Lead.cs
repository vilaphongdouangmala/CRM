using System.ComponentModel.DataAnnotations;

public class Lead {
  [Key]
  public int LeadId {get;set;}//pk label="Lead"
  public String FirstName {get;set;}//label="First_name"
  public String LastName {get;set;}//label="Last_name"
  public String Email {get;set;}//label="Email"
  public DateTime CreatedDate {get;set;}//label="Created_date"
  public DateTime LastContactedDate {get;set;}//label="Last_contacted_date"
  public String Source {get;set;}//label="Source"
  public int LeadStatusId {get;set;}//fk="LeadStatus"
  public LeadStatus LeadStatus {get;set;} //np

}//ec

