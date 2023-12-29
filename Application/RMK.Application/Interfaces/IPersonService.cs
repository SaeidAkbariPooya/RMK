using RMK.Application.DTOs;

namespace RMK.Application.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<PersonDto> GetAll();
        //IEnumerable<PersonDto> GetAllLinq();
    }
}
