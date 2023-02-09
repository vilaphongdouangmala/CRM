using System.ComponentModel.DataAnnotations;

public class Quote {
  [Key]
  public int QuoteId {get;set;}//pk label="Quotes"
  public String QuoteName {get;set;}//label="Quote_name"
  public DateTime CreatedDate {get;set;}//label="Created_date"
  public DateTime ModifiedDate {get;set;}//label="Modified_date"
  public DateTime ExpirationDate {get;set;}//label="Expiration_date"
  public double GrandTotal {get;set;}//label="Grand_total"
  public String Description {get;set;}//label="Description"
  public int QuoteStatusId {get;set;}//fk="QuoteStatus"
  public QuoteStatus QuoteStatus {get;set;} //np
  public List<QuoteItem> QuoteItems {get;set;}
//label="Quote_items"

}//ec

