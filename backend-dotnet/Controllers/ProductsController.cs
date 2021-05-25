using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POS.Backend.Data;
using POS.Backend.DTOs;
using POS.Backend.Models;

namespace POS.Backend.Controllers{
  
  [Route("api/products")]
  [ApiController]
  public class ProductController : ControllerBase{
    private readonly IRepository<Product> _repo;
    private readonly IMapper _mapper;

    public ProductController(IRepository<Product> repository, IMapper mapper){
      _repo = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult <IEnumerable<ProductViewDataDTO>> GetAllProducts(){
      var list = _repo.GetAll();
      return Ok(_mapper.Map<IEnumerable<ProductViewDataDTO>>(list));
    }

    [HttpGet("{id}", Name="GetProductById")]
    public ActionResult <ProductViewDataDTO> GetProductById(int id){
      var product = _repo.GetById(id);
      if (product != null)
        return Ok(_mapper.Map<ProductViewDataDTO>(product));
      else
        return NotFound();
    }

    [HttpPost]
    public ActionResult <ProductViewDataDTO> InsertProduct(ProductInsertDTO p){
      var product = _mapper.Map<Product>(p);
      _repo.Insert(product);
      _repo.SaveChanges();
      var productViewData = _mapper.Map<ProductViewDataDTO>(product);
      return CreatedAtRoute(nameof(GetProductById),
                            new { id = productViewData.id },
                            productViewData);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id, ProductUpdateDTO productUpdate){
      var product = _repo.GetById(id);
      if (product == null)
        return NotFound();
      
      _mapper.Map(productUpdate, product);
      _repo.Update(product);
      _repo.SaveChanges();
      return NoContent();
    }

  }
}