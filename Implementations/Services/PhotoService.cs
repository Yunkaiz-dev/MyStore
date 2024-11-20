using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Photo;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoService;

        public PhotoService(IPhotoRepository photoService)
        {
            _photoService = photoService;
        }

        public PhotoDto Create(CreatePhotoDto createPhotoDto)
        {
            var photo = _photoService.Create(createPhotoDto);
            var photoDto = new PhotoDto
            {
                // Mapeo de propiedades por completar
                PhotoId =photo.PhotoId,
                PhotoName =photo.PhotoName,
                PhotoUrl =photo.PhotoUrl,
                CreateDateTime = DateTime.Now,
                ModifiedDateTime = DateTime.Now,
            };
            return photoDto;
        }

        public void Delete(int id)
        {
            _photoService.Delete(id);
        }

        public List<PhotoDto> Get()
        {
            var photos = _photoService.Get();
            var photoDtos = new List<PhotoDto>();

            foreach (Photo photo in photos)
            {
                var dto = new PhotoDto
                {
                    // Mapeo de propiedades por completar
                    PhotoId = photo.PhotoId,
                    PhotoName = photo.PhotoName,
                    PhotoUrl = photo.PhotoUrl,
                    CreateDateTime = DateTime.Now,
                    ModifiedDateTime = DateTime.Now,
                };
                photoDtos.Add(dto);
            }
            return photoDtos;
        }

        public Photo GetById(int id)
        {
            return _photoService.GetById(id);
        }

        public PhotoDto Update(int id, UpdatePhotoDto updatePhotoDto)
        {
            var photo = _photoService.Update(id, updatePhotoDto);
            var photoDto = new PhotoDto
            {
                // Mapeo de propiedades por completar
                PhotoId = photo.PhotoId,
                PhotoName = photo.PhotoName,
                PhotoUrl = photo.PhotoUrl,
                CreateDateTime = DateTime.Now,
                ModifiedDateTime = DateTime.Now,
            };
            return photoDto;
        }

    }
}
