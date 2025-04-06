using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mango.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Empanada",
                Price = 15,
                Description = " Disfruta de nuestra deliciosa empanada, con una masa dorada y crujiente, rellena de un exquisito guiso casero que combina ingredientes frescos y especias cuidadosamente seleccionadas. Disponible en variedades como carne jugosa, pollo sazonado, queso derretido o la clásica mixta. ¡Perfecta para acompañar con nuestra salsa especial!",
                //ImageUrl = "https://placehold.co/603x403",
                ImageUrl = "images/product/empanadas.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paella",
                Price = 13.99,
                Description = " Déjate conquistar por el auténtico sabor de nuestra paella, una receta llena de tradición y pasión. Arroz perfectamente sazonado, mariscos frescos, jugosos trozos de pollo y una combinación de especias que transportan tu paladar directo a España.",
                //ImageUrl = "https://placehold.co/602x402",
                ImageUrl = "images/product/paella.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Pasta",
                Price = 10.99,
                Description = " Sumérgete en el auténtico sabor de Italia con nuestra pasta artesanal, cocida al dente y bañada en una irresistible salsa casera. Desde una cremosa Alfredo, hasta la clásica Boloñesa con carne sazonada a la perfección.",
                //ImageUrl = "https://placehold.co/601x401",
                ImageUrl = "images/product/pasta.jpg",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Suchi",
                Price = 15,
                Description = " Déjate llevar por la delicadeza y frescura de nuestro sushi, elaborado con ingredientes de la más alta calidad. Desde el clásico rollo de salmón y aguacate hasta opciones tempurizadas y especiales con un toque único.!",
                //ImageUrl = "https://placehold.co/600x400",
                ImageUrl = "images/product/suchi.jpg",
                CategoryName = "Entree"
            });
        }
    }
}
