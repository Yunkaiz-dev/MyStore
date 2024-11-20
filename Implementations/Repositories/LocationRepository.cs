using MyStore.Abstractions.Repositories;
using MyStore.Dtos.Location;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly StoreDbContext _dbContext;

        public LocationRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Location Create(CreateLocationDto locationDto)
        {
            var result = new Location()
            {
                UserId = locationDto.UserId,
                LocationStreet = locationDto.LocationStreet,
                LocationCountry = locationDto.LocationCountry,
                LocationState = locationDto.LocationState,
                LocationZip = locationDto.LocationZip,
                CreatedDateTime = locationDto.CreatedDateTime,
                ModifiedDateTime = locationDto.ModifiedDateTime,
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public Location Update(int id,UpdateLocationDto locationDto)
        {
            var LocationExist = GetById(id);

            LocationExist.UserId = locationDto.UserId ?? LocationExist.UserId;
            LocationExist.LocationStreet = locationDto.LocationStreet ?? LocationExist.LocationStreet;
            LocationExist.LocationCountry = locationDto.LocationCountry ?? LocationExist.LocationCountry;
            LocationExist.LocationState = locationDto?.LocationState ?? LocationExist.LocationState;
            LocationExist.LocationZip = locationDto?.LocationZip ?? LocationExist.LocationZip;
            LocationExist.CreatedDateTime = locationDto?.CreatedDateTime ?? LocationExist.CreatedDateTime;
            LocationExist.ModifiedDateTime = locationDto?.ModifiedDateTime ?? LocationExist.ModifiedDateTime;

            _dbContext.Update(LocationExist);
            _dbContext.SaveChanges();

            var UpdatedLocation = GetById(id);
            return UpdatedLocation;
        }

        public void Delete(int id)
        {
            Location location = GetById(id);
            _dbContext.Remove(location);
            _dbContext.SaveChanges();
        }

        public List<Location> Get()
        {
            return [.. _dbContext.Locations];
        }

        public Location GetById(int id)
        {
            return _dbContext.Locations.Where(p => p.LocationId == id).FirstOrDefault();
        }
    }
}
