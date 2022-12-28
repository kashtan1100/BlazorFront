namespace BlazorApp.Models
{
    public class Course
    {
        public int Id;
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Lesson> lessons { get; set; }
    }
}
