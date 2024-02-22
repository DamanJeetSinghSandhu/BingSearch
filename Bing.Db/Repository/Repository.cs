using Bing.Models;
using Microsoft.EntityFrameworkCore;
using Sink.Logger.Models;

namespace Bing.Db.Repository
{
        public class Repository : IRepository
        {
            private readonly BingDbContext _context;

            public Repository(BingDbContext context)
            {
                _context = context;
            }

            public void Add(Location entity)
            {
                _context.Set<Location>().Add(entity);
                SaveChanges();
            }

            public List<Location> GetLocation(TimeSpan startTime, TimeSpan endTime)
            {
           
            return _context.Set<Location>().Where(location =>location.AvailFrom >= startTime
            && location.AvailTo <= endTime ).ToList();

        }


        public void SaveChanges()
        {
           _context.SaveChanges();
        }
    }
}
