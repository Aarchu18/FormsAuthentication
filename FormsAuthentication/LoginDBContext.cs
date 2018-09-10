using FormsAuthentication.DAL;
using Microsoft.EntityFrameworkCore;

namespace FormsAuthentication
{
    public class LoginDBContext:DbContext
    {
        public DbSet<LoginList> UserTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=KELLGGNCPU0229\SQLEXPRESS;Initial Catalog=SampleExercise;Integrated Security=True");
        }
    }
}
