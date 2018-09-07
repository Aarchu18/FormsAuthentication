using FormsAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAuthentication.Repository
{
    public class CredentialData
    {
        public static List<UserModel> GetAllUsers()
        {
            return new List<UserModel>
            {
                new UserModel
                {
                    UserId=1,
                    UserName="user1",
                    Password="password",
                    FullName="John Cena",
                    DOB=DateTime.Now,
                    Location="US"
                },
                 new UserModel
                {
                    UserId=2,
                    UserName="user2",
                    Password="password",
                    FullName="The Undertaker",
                    DOB=DateTime.Today,
                    Location="UK"
                },
                  new UserModel
                {
                    UserId=1,
                    UserName="user3",
                    Password="password",
                    FullName="Hulk Hogan",
                    DOB=DateTime.UtcNow,
                    Location="Canada"
                }
            };
        }
    }
}
