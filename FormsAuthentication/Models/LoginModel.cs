using System.Collections.Generic;

namespace FormsAuthentication.Models
{
    public class LoginModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        public ICollection<UserModel> userModel { get; set; }
    }
}
