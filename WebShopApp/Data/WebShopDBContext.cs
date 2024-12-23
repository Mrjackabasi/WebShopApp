using Microsoft.EntityFrameworkCore;

namespace WebShopApp.Data
{
    public class WebShopDBContext:DbContext
    {
        public WebShopDBContext(DbContextOptions<WebShopDBContext> options) : base(options) { }
    }
}
