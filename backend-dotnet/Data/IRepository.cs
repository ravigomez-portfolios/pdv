using System;
using System.Collections.Generic;
using POS.Backend.Models;

namespace POS.Backend.Data {  
  public interface IRepository<T> where T: BaseEntity {  
    IEnumerable < T > GetAll();  
    T GetById(Int64 id);  
    void Insert(T entity);  
    void Update(T entity);  
    void Delete(T entity);  
  }  
}  