using Microsoft.EntityFrameworkCore;
using POS.Backend.Models;

namespace POS.Backend.Data{
   public class Context : DbContext{
     public Context(DbContextOptions<Context> opt) : base(opt){

     }
     public DbSet<Product> Products {get; set;}
   }
 }