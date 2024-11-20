using MyStore.Dtos.Location;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface ILocationRepository
    {
        List<Location> Get();

        Location GetById(int id);

        Location Create(CreateLocationDto createLocationDto);

        Location Update(int id, UpdateLocationDto updateLocationDto);

        void Delete(int id);
    }
}
