using LoginWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginWebApp.Services
{
    public class SecurityServices
    {
        List<UserModel> knownusers = new List<UserModel>();

        public SecurityServices()
        { 
            knownusers.Add(new UserModel { Id = 0, username = "John", password = "JohnDoe21@" });
            knownusers.Add(new UserModel { Id = 0, username = "Paul", password = "Password1" });
            knownusers.Add(new UserModel { Id = 0, username = "Mike", password = "Micheal25" });
            knownusers.Add(new UserModel { Id = 0, username = "Tara", password = "Teaching21" });
        }
        public bool isValid(UserModel user)
        {
            return knownusers.Any(x => x.username == user.username && x.password == user.password);
        }

    }
}
