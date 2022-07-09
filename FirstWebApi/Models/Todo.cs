namespace FirstWebApi.Models
{
	public class Todo
	{
        public long Id { get; set; }

        public string? Task { get; set; }

        public string? Notes { get; set; }

        public DateTime Created { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? DateCompleted { get; set; }

        //replace those two for Enums 
        public string? TeamName { get; set; }
        //this will be an ID on the DB, and when returning
        //using an endpoint, a viewModel will return
        //the Status code (Taken from EnumTypeItem)
        public bool IsCompleted { get; set; }

    }
}

