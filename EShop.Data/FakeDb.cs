using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System.Collections.Generic;

namespace EShop.Data
{
    public class FakeDb : IContext
    {
        List<User> IContext.Users { get => Users; set => Users =value; }
        List<Product> IContext.Products { get => Products; set => Products = value; }

        private List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Kostia",
                Surname = "Salabai",
                Email = "SalabayKostya@gmail.com",
                City = "Kiev",
                Address = "Bilshov38",
                Password = "12345678",
                Role = Roles.Registered        
            },
            new User
            {
                Id = 2,
                Name = "Vika",
                Surname = "Chorna",
                Email = "Viki@gmail.com",
                City = "Uman",
                Address = "Nezalejnosti22-A",
                Password = "1234321",
                Role = Roles.Guest
            },
            new User
            {
                Id = 3,
                Name = "Nazar",
                Surname = "Kachan",
                Email = "NKachan@gmail.com",
                City = "Kiev",
                Address = "Yangelia 78",
                Password = "5824ec6d",
                Role = Roles.Admin
            }
        };

        private List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Red pen",
                Price = 5,
                Count = 10,
                ProductType = ProductType.Pen,
                Description = "A tool for writing, drawing or sketching in which " +
                "a thin written graphite core is embedded in a shell of another material. " +
                "The shell in wooden pencils"
            },
            new Product
            {
                Id = 2,
                Name = "Line notebook",
                Price = 9,
                Count = 20,
                ProductType = ProductType.Notebook,
                Description ="The notebook will delight you with its favorable cost and quality. " +
                "The inner block is made of 55.0 g / m2 offset paper, and the cover is 90.0 g / m2. " +
                "Each page has red markup."
            },
            new Product
            {
                Id = 3,
                Name = "Super Diary",
                Price = 15,
                Count = 7,
                ProductType = ProductType.Diary,
                Description ="A leather-bound notebook with a designer pen is perfect as a presentable" +
                " gift for a man or a woman! The notebook is made by hand from fine Crazy Horse genuine leather. " +
                "The notebook is made in B6 format (17.5x13.5x3.5 cm)"
            },
            new Product
            {
                Id = 4,
                Name = "Notebook in a cell",
                Price = 10,
                Count = 7,
                ProductType = ProductType.Notebook,
                Description ="Notebook A4, 96 sheets, squared, staple (4820)"
            }
            
        };

        private List<Cart> Carts = new List<Cart>
        {
         
        };

        private List<Order> Orders = new List<Order>
        {
          
        };

       
    }
}
