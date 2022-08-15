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

        public TeamNames? TeamName { get; set; }

        public TodoItemStatus Status { get; set; }

    }
}

