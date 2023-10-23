namespace CarWorkshop.MVC.Models
{
    public class About
    {
        public string? Title { get; set; }
        public string? Description { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
    }
}
