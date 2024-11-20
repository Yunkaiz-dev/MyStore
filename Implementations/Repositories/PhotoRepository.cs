using MyStore.Abstractions.Repositories;
using MyStore.Dtos.Photo;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class PhotoRepository:IPhotoRepository
    {
        private readonly StoreDbContext _dbContext;

        public PhotoRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Photo Create(CreatePhotoDto createPhotoDto)
        {
            var result = new Photo()
            {
                // Mapeo por completar
                PhotoName = createPhotoDto.PhotoName,
                PhotoUrl = createPhotoDto.PhotoUrl,
                CreateDateTime = createPhotoDto.CreateDateTime,
                ModifiedDateTime = createPhotoDto.ModifiedDateTime
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public Photo Update(int id, UpdatePhotoDto updatePhotoDto)
        {
            var photoExist = GetById(id);

            // Mapeo por completar
            photoExist.PhotoName = updatePhotoDto.PhotoName ?? photoExist.PhotoName;
            photoExist.PhotoUrl = updatePhotoDto.PhotoUrl ?? photoExist.PhotoUrl;
            photoExist.CreateDateTime = updatePhotoDto.CreateDateTime ?? photoExist.CreateDateTime;
            photoExist.ModifiedDateTime = updatePhotoDto.ModifiedDateTime ?? photoExist.ModifiedDateTime;

            _dbContext.Update(photoExist);
            _dbContext.SaveChanges();

            var updatedPhoto = GetById(id);
            return updatedPhoto;
        }

        public void Delete(int id)
        {
            Photo photo = GetById(id);
            _dbContext.Remove(photo);
            _dbContext.SaveChanges();
        }

        public List<Photo> Get()
        {
            return _dbContext.Photos.ToList();
        }

        public Photo GetById(int id)
        {
            return _dbContext.Photos.Where(p => p.PhotoId == id).FirstOrDefault();
        }

    }
}
