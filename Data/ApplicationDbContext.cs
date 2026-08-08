using Microsoft.EntityFrameworkCore;
using FinalProjectGroup3.Models;

namespace FinalProjectGroup3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TeamMemberData> TeamMemberData { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<TravelDestination> TravelDestinations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TravelDestination>().HasData(
                new TravelDestination
                {
                    Id = 1,
                    DestinationName = "Kyoto",
                    Country = "Japan",
                    Description = "Historic temples, gardens, and traditional tea houses.",
                    BestSeasonToVisit = "Spring",
                    Rating = 5
                },
                new TravelDestination
                {
                    Id = 2,
                    DestinationName = "Santorini",
                    Country = "Greece",
                    Description = "Whitewashed cliffside villages overlooking the Aegean Sea.",
                    BestSeasonToVisit = "Summer",
                    Rating = 5
                },
                new TravelDestination
                {
                    Id = 3,
                    DestinationName = "Banff",
                    Country = "Canada",
                    Description = "Turquoise lakes surrounded by the Canadian Rockies.",
                    BestSeasonToVisit = "Fall",
                    Rating = 4
                }
            );

            modelBuilder.Entity<Cat>().HasData(
                new Cat
                {
                    Id = 1,
                    Name = "Whiskers",
                    Age = 3,
                    HasAutoFeeder = true,
                    FurColor = "Orange"
                },
                new Cat
                {
                    Id = 2,
                    Name = "Luna",
                    Age = 5,
                    HasAutoFeeder = false,
                    FurColor = "Black"
                },
                new Cat
                {
                    Id = 3,
                    Name = "Milo",
                    Age = 1,
                    HasAutoFeeder = true,
                    FurColor = "Gray"
                }
            );

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame
                {
                    Id = 1,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Engine = "Proprietary",
                    ReleaseYear = 2017,
                    IsMultiplayer = false
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "Fortnite",
                    Engine = "Unreal Engine",
                    ReleaseYear = 2017,
                    IsMultiplayer = true
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "Stardew Valley",
                    Engine = "MonoGame",
                    ReleaseYear = 2016,
                    IsMultiplayer = true
                }
            );

            modelBuilder.Entity<TeamMemberData>().HasData(
                new TeamMemberData
                {
                    Id = 1,
                    FullName = "Sample Student One",
                    Birthdate = new DateTime(2003, 4, 12),
                    CollegeProgram = "Information Technology",
                    YearInProgram = 3
                },
                new TeamMemberData
                {
                    Id = 2,
                    FullName = "Sample Student Two",
                    Birthdate = new DateTime(2002, 9, 25),
                    CollegeProgram = "Computer Science",
                    YearInProgram = 4
                }
            );
        }
    }
}
