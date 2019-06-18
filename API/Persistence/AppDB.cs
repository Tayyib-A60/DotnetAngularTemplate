using Microsoft.EntityFrameworkCore;

namespace API.Persistence
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {}
    }
}