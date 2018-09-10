using System.Collections.Generic;
using System.Linq;

namespace FormsAuthentication.DAL
{
    public class DBOperation
    {
        public List<LoginList>GetAllUser()
        {
            using (LoginDBContext model = new LoginDBContext())
            {
                return (model.UserTable).ToList();
            }
        }
    }
}
