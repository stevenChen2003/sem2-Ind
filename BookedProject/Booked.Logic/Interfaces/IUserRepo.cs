using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
    public interface IUserRepo
    {
        User FindUserByEmail(string email);
        IEnumerable<User> GetAllUser();
        void AddUser(User user);
        void UpdateUser(User user);
        void RemoveUserByEmail(int id);
        string GetHashedAndSaltPassword(string email);
    }
}
