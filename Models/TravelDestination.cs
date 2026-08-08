namespace FinalProjectGroup3.Models
{
    public class TravelDestination
    {
        public int Id { get; set; }

        public string DestinationName { get; set; }

        public string Country { get; set; }

        public string Description { get; set; }

        public string BestSeasonToVisit { get; set; }

        public int Rating { get; set; } // scale of 1 to 5
    }
}
