using RMK.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace RMK.Domain.Models.Account
{
    public class User: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
