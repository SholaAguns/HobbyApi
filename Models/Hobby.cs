namespace HobbyApi.Models
{
    public class Hobby
    {
        public Hobby()
        {

        }
        public Hobby(string Name)
        {
            this.Name = Name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }

        public double Rating { get; set; }
    }
}
