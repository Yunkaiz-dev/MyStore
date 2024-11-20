using MyStore.Dtos.Location;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface ILocationService
    {
        List<LocationDto> Get();

        Location GetById(int id);

        LocationDto Create(CreateLocationDto createLocationDto);

        LocationDto Update(int id, UpdateLocationDto updateLocationDto);

        void Delete(int id);
    }
}
