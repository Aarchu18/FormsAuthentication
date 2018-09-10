using System.ComponentModel.DataAnnotations;

namespace FormsAuthentication.DAL
{
    public class LoginList
    {
        [Key]
        public int UserId { set; get; }
        [Required]
        public string UserName { set; get; }
        [Required]
        public string UserPassword { set; get; }
    }
}
