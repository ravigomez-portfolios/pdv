using System.Collections.Generic;
using System.Linq;
using POS.Backend.Models;

namespace POS.Backend.Data{
  public class ProductRepo : IRepository<Product>
  {
    private readonly Context _context;

    public ProductRepo(Context context)
    {
        _context = context;
    }
    public void Delete(Product entity)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
      return _context.Products.ToList();
    }
    public Product GetById(long id)
    {
      return _context.Products.FirstOrDefault(p => p.id == id);
    }

    public void Insert(Product entity)
    {
      _context.Products.Add(entity); 
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void Update(Product entity)
    {
      throw new System.NotImplementedException();
    }
  }
}