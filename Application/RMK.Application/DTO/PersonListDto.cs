using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMK.Application.DTOs
{
    public class PersonListDto
    {
        public virtual ICollection<PersonDto> PersonList { get; set; }
    }
}
