using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Backend.Models {
  public class BaseEntity {
    [Key]
    public Int64 id {get; set;}
    public DateTime AddedDate {get; set;}
    public DateTime? ModifiedDate {get; set;}
  }
}