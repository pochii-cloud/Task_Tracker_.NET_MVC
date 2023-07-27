namespace Todo.Models.Domain
{
    public class Task
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Is_Complete { get; set; }

        public DateTime Published { get; set; }

    }
}
