using Bing.Db;
using Bing.Db.Repository;
using Bing.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;

namespace Bing.Search.Test
{
    public class LocationTests
    {
       
        [Fact]
        public void AddGetLocation_ReturnsLocationsInRange()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BingDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new BingDbContext(options))
            {
                var repository = new Repository(context);
                repository.Add(new Location { Name = "Location 1", AvailFrom = TimeSpan.FromHours(8), AvailTo = TimeSpan.FromHours(12) });
                repository.Add(new Location { Name = "Location 2", AvailFrom = TimeSpan.FromHours(10), AvailTo = TimeSpan.FromHours(14) });
                repository.Add(new Location { Name = "Location 3", AvailFrom = TimeSpan.FromHours(9), AvailTo = TimeSpan.FromHours(13) });
                repository.SaveChanges();
            }

            using (var context = new BingDbContext(options))
            {
                var repository = new Repository(context);
                var startTime = TimeSpan.FromHours(9);
                var endTime = TimeSpan.FromHours(13);

                // Act
                var locations = repository.GetLocation(startTime, endTime);

                // Assert
                Assert.NotNull(locations);
                Assert.Equal(1, locations.Count);
                Assert.Equal("Location 3", locations[0].Name);

            }
        }
    }
}