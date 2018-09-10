using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class IDBOperations
    {
        int AddUser(Product product);

        IEnumerable<Product> GetUsers();
    }
}
