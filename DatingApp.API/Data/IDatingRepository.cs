using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll(); // Saving changes in database.
         Task<IEnumerable<User>> GetUsers(); // Return list of users.
         Task<User> GetUser(int id);
    }
}