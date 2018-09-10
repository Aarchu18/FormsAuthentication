using System.Collections.Generic;
using System.Linq;

namespace FormsAuthentication.DAL
{
    public class DBOperation
    {
        public List<LoginList>GetAllUser()
        {
            using (LoginDBContext loginDBContext = new LoginDBContext())
            {
                return (loginDBContext.UserTable).ToList();
            }
        }
    }
}
