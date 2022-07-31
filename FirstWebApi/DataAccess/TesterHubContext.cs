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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Tester>()
				.HasData(new Tester
                {
                    Id = 1,
                    FirstName = "Antonio",
                    LastName = "Banderas",
                    JoinedHub = new DateTime(2021, 7, 5).Date,
                    CodeReviewer = true,
                    TeamName = TeamNames.Daybreak
                },
                new Tester
                {
                    Id = 2,
                    FirstName = "Virginia",
                    LastName = "South",
                    JoinedHub = new DateTime(2019, 2, 7).Date,
                    CodeReviewer = false,
                    TeamName = TeamNames.GalaxyAngular
                },
                new Tester
                {
                    Id = 3,
                    FirstName = "Jean",
                    LastName = "Mcklaine",
                    JoinedHub = new DateTime(2021, 8, 20).Date,
                    CodeReviewer = true,
                    TeamName = TeamNames.KnightFall
                },
                new Tester
                {
                    Id = 4,
                    FirstName = "Angel",
                    LastName = "Heart",
                    JoinedHub = new DateTime(2022, 3, 14).Date,
                    CodeReviewer = false,
                    TeamName = TeamNames.Daybreak
                },
                new Tester
                {
                    Id = 5,
                    FirstName = "Chris",
                    LastName = "Sky",
                    JoinedHub = new DateTime(2018, 6, 28).Date,
                    CodeReviewer = true,
                    TeamName = TeamNames.ReleaseTeam
                });
        }

		public DbSet<Tester> Tester { get; set; }
		public DbSet<Todo> Todo { get; set; }
	
	}
}

