using System.ComponentModel.DataAnnotations;

public class OpportunityStatus {
  [Key]
  public int OpportunityStatusId {get;set;}//pk label="Opportunity_status"
  public String StatusName {get;set;}//label="Status_name"

}//ec

