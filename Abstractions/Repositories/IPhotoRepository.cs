using MyStore.Dtos.Category;
using MyStore.Dtos.Photo;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface IPhotoRepository
    {
        List<Photo> Get();

        Photo GetById(int id);

        Photo Create(CreatePhotoDto createPhotoDto);

        Photo Update(int id, UpdatePhotoDto updatePhotoDto);

        void Delete(int id);
    }
}
