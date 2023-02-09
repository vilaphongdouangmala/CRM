using System.ComponentModel.DataAnnotations;

public class Account {
  [Key]
  public int AccountId {get;set;}//pk label="Account"
  public String Type {get;set;}//label="Type"
  public String Website {get;set;}//label="Website"
  public DateTime CreatedDate {get;set;}//label="Created_date"
  public DateTime ModifiedDate {get;set;}//label="Modified_date"

}//ec

