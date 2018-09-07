using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace FormsAuthentication.Models
{
    public partial class LoginContext: DbContext
    {
        public LoginContext() : base()
        {

        }

        public DbSet<UserModel> Students { get; set; }
        public DbSet<LoginModel> Grades { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
    
}
