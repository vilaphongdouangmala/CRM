using System.ComponentModel.DataAnnotations;

public class QuoteStatus {
  [Key]
  public int QuoteStatusId {get;set;}//pk label="Quote_status"
  public String StatusName {get;set;}//label="Status_name"

}//ec

