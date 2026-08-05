namespace FinalProjectGroup3.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Engine { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsMultiplayer { get; set; }
    }
}