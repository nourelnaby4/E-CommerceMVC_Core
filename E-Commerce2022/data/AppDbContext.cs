using Microsoft.EntityFrameworkCore;

namespace E_Commerce2022.data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}
