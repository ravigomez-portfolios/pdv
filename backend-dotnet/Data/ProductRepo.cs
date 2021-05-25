using System;
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
      if (entity == null) throw new ArgumentNullException(nameof(entity));
      
      _context.Remove(entity);
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
      if (entity == null) throw new ArgumentNullException(nameof(entity));

      _context.Products.Add(entity); 
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void Update(Product entity)
    {
      _context.Products.Update(entity);
    }
  }
}