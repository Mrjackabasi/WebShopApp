using Microsoft.EntityFrameworkCore;
using WebShopApp.Models;

namespace WebShopApp.Data
{
    public class WebShopDBContext:DbContext
    {
        public WebShopDBContext(DbContextOptions<WebShopDBContext> options) : base(options) { }
        public DbSet<Product> products { get; set; }
    }
}
