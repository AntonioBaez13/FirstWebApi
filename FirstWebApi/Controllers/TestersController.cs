using FirstWebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestersController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Tester> GetTesters()
        {
            IEnumerable<Tester> testers = new List<Tester>() {
                new Tester
                {
                    Id = 1,
                    FirstName = "Antonio",
                    LastName = "Banderas",
                    JoinedHub = new DateTime(2021, 7, 5),
                    CodeReviewer = true,
                    TeamName = TeamNames.Daybreak
                },
                new Tester
                {
                    Id = 2,
                    FirstName = "Virginia",
                    LastName = "South",
                    JoinedHub = new DateTime(2019, 2, 7),
                    CodeReviewer = false,
                    TeamName = TeamNames.GalaxyAngular
                },
                new Tester
                {
                    Id = 3,
                    FirstName = "Jean",
                    LastName = "Mcklaine",
                    JoinedHub = new DateTime(2021, 8, 20),
                    CodeReviewer = true,
                    TeamName = TeamNames.KnightFall
                },
                new Tester
                {
                    Id = 4,
                    FirstName = "Angel",
                    LastName = "Heart",
                    JoinedHub = new DateTime(2022, 3, 14),
                    CodeReviewer = false,
                    TeamName = TeamNames.Daybreak
                },
                new Tester
                {
                    Id = 5,
                    FirstName = "Chris",
                    LastName = "Sky",
                    JoinedHub = new DateTime(2018, 6, 28),
                    CodeReviewer = true,
                    TeamName = TeamNames.ReleaseTeam
                }
            };

            return testers;
        }

    }
}

