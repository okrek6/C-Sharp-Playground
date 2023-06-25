namespace C_Sharp_Playground.Models
{
    public class TaskModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Assignee { get; set; }
        public string Secret { get; set; }
    }
}