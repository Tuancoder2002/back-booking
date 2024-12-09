using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyFirstWebAPIProject.Models;

namespace MyFirstWebAPIProject.Controller
{
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return new List<Product> 
        {
            new Product { Id = 1, Name = "Product 1", Price = 100 },
            new Product { Id = 2, Name = "Product 2", Price = 200 },
            new Product { Id = 3, Name = "Product 3", Price = 300 }
        };
    }
}
}