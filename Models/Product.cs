using System.ComponentModel.DataAnnotations;

public class Product {
  [Key]
  public int ProductId {get;set;}//pk label="Product"
  public String ProductName {get;set;}//label="Product_name"
  public double Price {get;set;}//label="Price"

}//ec

