using System;  
namespace POS.Backend.Models {
  public class BaseEntity {
    public Int64 id {get; set;}
    public DateTime AddedDate {get; set;}
    public DateTime ModifiedDate {get; set;}
  }
}