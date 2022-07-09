using FirstWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.DataAccess
{
	public class TesterHubContext : DbContext
	{
		public TesterHubContext(DbContextOptions<TesterHubContext> options)
			: base(options)
        {
        }

		public DbSet<Tester> Tester { get; set; }
		public DbSet<Todo> Todo { get; set; }
	
	}
}

