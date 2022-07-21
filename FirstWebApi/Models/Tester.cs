namespace FirstWebApi.Models
{
	public class Tester
	{
        public long Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime JoinedHub { get; set; }

        public bool CodeReviewer { get; set; }

        public TeamNames? TeamName { get; set; }

    }
}

