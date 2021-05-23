using System.Collections.Generic;
using POS.Backend.Models;

namespace POS.Backend.Data{
  public class ProductRepo : IRepository<Product>
  {
    public void Delete(Product entity)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
      var list = new List<Product>{
        new Product{id=1, Name="Blue Ball", Description="Blue Ball from JJ inc"},
        new Product{id=2, Name="Green Ball", Description="Green Ball from JJ inc"},
        new Product{id=3, Name="White Ball", Description="White Ball from JJ inc"}
      };
      return list;
    }
    public Product GetById(long id)
    {
      return new Product{id=id, Name="Blue Ball", Description="Blue Ball from JJ inc"};
    }

    public void Insert(Product entity)
    {
      throw new System.NotImplementedException();
    }

    public void Update(Product entity)
    {
      throw new System.NotImplementedException();
    }
  }
}