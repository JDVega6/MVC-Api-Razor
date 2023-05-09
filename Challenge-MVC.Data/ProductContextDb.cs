using Challenge_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge_MVC.Data
{
    public class ProductContextDb : DbContext
    {
        public ProductContextDb()
        { }

        public ProductContextDb(DbContextOptions<ProductContextDb> options)
            : base(options)
        { }
        public DbSet<Products> Products { get; set; }
    }
}