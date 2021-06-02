using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using POS.Backend.Data;
using POS.Backend.DTOs;
using POS.Backend.Models;

namespace POS.Backend.Controllers{
  
  [Authorize]
  [Route("api/products")]
  [ApiController]
  public class ProductController : ControllerBase{
    private readonly IRepository<Product> _repo;
    private readonly IMapper _mapper;

    public ProductController(IRepository<Product> repository, IMapper mapper){
      _repo = repository;
      _mapper = mapper;
    }

    /// <summary>
    /// List all products on the database.
    /// </summary>
    [HttpGet]
    public ActionResult <IEnumerable<ProductViewDataDTO>> GetAllProducts(){
      var list = _repo.GetAll();
      return Ok(_mapper.Map<IEnumerable<ProductViewDataDTO>>(list));
    }

    /// <summary>
    /// Get one product by ID.
    /// </summary>
    [HttpGet("{id}", Name="GetProductById")]
    public ActionResult <ProductViewDataDTO> GetProductById(int id){
      var product = _repo.GetById(id);
      if (product != null)
        return Ok(_mapper.Map<ProductViewDataDTO>(product));
      else
        return NotFound();
    }

    /// <summary>
    /// Insert a product on the database.
    /// </summary>
    [HttpPost]
    public ActionResult <ProductViewDataDTO> InsertProduct(ProductInsertDTO p){
      var product = _mapper.Map<Product>(p);
      product.AddedDate = DateTime.UtcNow;
      _repo.Insert(product);
      _repo.SaveChanges();
      var productViewData = _mapper.Map<ProductViewDataDTO>(product);
      return CreatedAtRoute(nameof(GetProductById),
                            new { id = productViewData.id },
                            productViewData);
    }

    /// <summary>
    /// Update the entire product object (PUT) on the database.
    /// </summary>
    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id, ProductUpdateDTO productUpdate){
      var product = _repo.GetById(id);
      if (product == null)
        return NotFound();
      
      _mapper.Map(productUpdate, product);
      product.ModifiedDate = DateTime.UtcNow;
      _repo.Update(product);
      _repo.SaveChanges();
      return NoContent();
    }

    /// <summary>
    /// Partial product update (PATCH) on the database.
    /// </summary>
    [HttpPatch("{id}")]
    public ActionResult PartialUpdateProduct(int id, JsonPatchDocument<ProductUpdateDTO> patchProductUpdate){
      var product = _repo.GetById(id);
      
      if (product == null) return NotFound();
      
      var productToPatch = _mapper.Map<ProductUpdateDTO>(product);
      patchProductUpdate.ApplyTo(productToPatch, ModelState);
      
      if (! TryValidateModel(productToPatch)) return ValidationProblem(ModelState);
      
      _mapper.Map(productToPatch, product);
      product.ModifiedDate = DateTime.UtcNow;
      _repo.Update(product);
      _repo.SaveChanges();
      return NoContent();
    }

    /// <summary>
    /// Delete a product on the database.
    /// </summary>
    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id){
      var product = _repo.GetById(id);
      if (product == null) return NotFound();
      
      _repo.Delete(product);
      _repo.SaveChanges();
      return NoContent();
    }

  }
}