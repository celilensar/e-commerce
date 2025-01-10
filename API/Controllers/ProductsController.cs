using System;
using API.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]

    public IActionResult GetProducts()
    {

        return Ok(new List<Product>(){
                new Product() { Id =1, Name="Iphone 15", Description="Telefon açıklaması", ImageUrl="1.jpg", IsActive= true, Price=18000, Stock= 100},
                new Product() { Id =2, Name="Iphone 16", Description="Telefon açıklaması", ImageUrl="1.jpg", IsActive= true, Price=18000, Stock= 100},
                new Product() { Id =3, Name="Iphone 17", Description="Telefon açıklaması", ImageUrl="1.jpg", IsActive= true, Price=18000, Stock= 100},

        });

    }

    [HttpGet("{id}")]

    public IActionResult GetProduct(int id)
    {
        return Ok(
            new Product() { Id = 1, Name = "Iphone 15", Description = "Telefon açıklaması", ImageUrl = "1.jpg", IsActive = true, Price = 18000, Stock = 100 }



        );
    }
}
