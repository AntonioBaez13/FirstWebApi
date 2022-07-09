namespace FirstWebApi.Models
{
	public class Tester
	{
        public long Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime JoinedHub { get; set; }

        public bool CodeReviewer { get; set; }

        //to replace after the team relationship has been stablished
        public string? TeamName { get; set; }
        //For the future for now let's keep it simple and use simple models
        //public long TeamId { get; set; }


        //public Team? Team { get; set; }
    }
}

