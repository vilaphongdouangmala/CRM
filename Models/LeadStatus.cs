using System.ComponentModel.DataAnnotations;

public class LeadStatus {
  [Key]
  public int LeadStatusId {get;set;}//pk label="Lead_status"
  public String StatusName {get;set;}//label="Status_name"

}//ec

