using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Product.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FQMB7F5;Initial Catalog=Task;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Products> Products { get; set; }
    }
}
