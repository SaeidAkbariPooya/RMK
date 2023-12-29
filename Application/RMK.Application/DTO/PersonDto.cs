using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMK.Application.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<AddressDto> AddressList { get; set; }
    }

    public class AddressDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
