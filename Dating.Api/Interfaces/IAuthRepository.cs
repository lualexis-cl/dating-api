using System;
using System.Threading.Tasks;
using Dating.Api.Models;

namespace Dating.Api.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string userName, string password);

        Task<bool> UserExists(string userName);
    }
}
