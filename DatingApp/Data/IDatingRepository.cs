using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Models;

namespace DatingApp.Data
{
    public interface IDatingRepository
    {
        void Add<T> (T entity) where T: class;
        void Delete<T> (T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int Id);
        Task<Photo> GetPhoto(int Id);
        Task<Photo> GetMainPhotoForUser(int userId);
    }
}