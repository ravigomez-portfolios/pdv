using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using POS.Backend.Data;
using POS.Backend.Models;

namespace POS.Backend.Controllers{
  
  [Route("api/products")]
  [ApiController]
  public class ProductController : ControllerBase{
    private readonly IRepository<Product> _repo;

    public ProductController(IRepository<Product> repository){
      _repo = repository;
    }

    [HttpGet]
    public ActionResult <IEnumerable<Product>> GetAllProducts(){
      var list = _repo.GetAll();
      return Ok(list);
    }

    [HttpGet("{id}")]
    public ActionResult <Product> GetProductById(int id){
      var product = _repo.GetById(id);
      return Ok(product);

    }

  }
}