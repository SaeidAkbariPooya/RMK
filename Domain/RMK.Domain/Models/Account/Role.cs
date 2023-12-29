using System.ComponentModel.DataAnnotations;

namespace RMK.Domain.Models.Account
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
