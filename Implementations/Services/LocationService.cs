using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Location;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationService;

        public LocationService(ILocationRepository locationService)
        {
            _locationService = locationService;
        }
        public LocationDto Create(CreateLocationDto createLocationDto)
        {
            var Location = _locationService.Create(createLocationDto);
            var LocationDto = new LocationDto
            {
                LocationId = Location.LocationId,
                UserId = Location.UserId,
                LocationStreet = Location.LocationStreet,
                LocationCountry = Location.LocationCountry,
                LocationState = Location.LocationState,
                LocationZip = Location.LocationZip,
                CreatedDateTime = DateTime.UtcNow,
                ModifiedDateTime = DateTime.UtcNow,
            };
            return LocationDto;
        }

        public void Delete(int id)
        {
             _locationService.Delete(id);
        }

        public List<LocationDto> Get()
        {
            var locations = _locationService.Get();
            var LocationDtos = new List<LocationDto>();

            foreach (Location location in locations)
            {
                var result = new LocationDto
                {
                    LocationId = location.LocationId,
                    UserId = location.UserId,
                    LocationStreet = location.LocationStreet,
                    LocationCountry = location.LocationCountry,
                    LocationState = location.LocationState,
                    LocationZip = location.LocationZip,
                    CreatedDateTime = location.CreatedDateTime,
                    ModifiedDateTime = location.ModifiedDateTime,
                };
                LocationDtos.Add(result);
            }
            return LocationDtos;
        }

        public Location GetById(int id)
        {
            return _locationService.GetById(id);
        }

        public LocationDto Update(int id, UpdateLocationDto updateLocationDto)
        {
            var location = _locationService.Update(id, updateLocationDto);
            var LocationDto = new LocationDto
            {
                LocationId = location.LocationId,
                UserId = location.UserId,
                LocationStreet = location.LocationStreet,
                LocationCountry = location.LocationCountry,
                LocationState = location.LocationState,
                LocationZip = location.LocationZip,
                CreatedDateTime = location.CreatedDateTime,
                ModifiedDateTime = location.ModifiedDateTime,
            };
            return LocationDto;
        }
    }
}
