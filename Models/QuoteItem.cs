using System.ComponentModel.DataAnnotations;

public class QuoteItem {
  [Key]
  public int QuoteItemId {get;set;}//pk label="Quote_items"
  public int Qty {get;set;}//label="Qty"
  public int Discount {get;set;}//label="Discount"
  public int ProductId {get;set;}//fk="Product"
  public Product Product {get;set;} //np
  public int QuoteId {get;set;}//fk="Quote"
  public Quote Quote {get;set;} //np

}//ec

