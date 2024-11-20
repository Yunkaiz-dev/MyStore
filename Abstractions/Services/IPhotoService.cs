using MyStore.Dtos.Photo;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface IPhotoService
    {
        List<PhotoDto> Get();

        Photo GetById(int id);

        PhotoDto Create(CreatePhotoDto createPhotoDto);

        PhotoDto Update(int id, UpdatePhotoDto updatePhotoDto);

        void Delete(int id);
    }
}
