using Bing.Models;
public interface IRepository 
{
  
    void Add(Location entity);
    List<Location> GetLocation(TimeSpan startTime, TimeSpan endTime);

}