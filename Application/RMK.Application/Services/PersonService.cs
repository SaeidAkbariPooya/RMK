using RMK.Application.DTOs;
using RMK.Application.Interfaces;
using RMK.Domain.Interface;

namespace RMK.Application.Services
{
    public class PersonService : IPersonService
    {
        #region constractor
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<PersonDto> GetAll()
        {
            var result = _personRepository.GetAll();

            if (!result.Any()) return null;

            PersonListDto vmp = new PersonListDto();
            vmp.PersonList = new List<PersonDto>();

            foreach (var item in result)
            {
                PersonDto person = new PersonDto();
                person.Id = item.Id;
                person.FullName = item.FullName;

                person.AddressList = new List<AddressDto>();

                foreach (var model in item.Addresses)
                {
                    AddressDto address = new AddressDto();
                    address.Id = model.Id;
                    address.PersonId = item.Id;
                    address.City = model.City;
                    address.Street = model.Street;

                    person.AddressList.Add(address);
                }
                vmp.PersonList.Add(person);
            }

            return vmp.PersonList;
        }


        //public IEnumerable<PersonDto> GetAllLinq()
        //{
        //    PeopleDto vmp = new PeopleDto();
        //    vmp.PersonDtos = new List<PersonDto>();

        //    foreach (var item in _personRepository.GetAllLinq())
        //    {
        //        PersonDto person = new PersonDto();
        //        person.FullName = item.FullName;

        //        person.AddressList = new List<AddressDto>();

        //        foreach (var model in item.Addresses.Where(s=>s.PersonId == item.Id))
        //        {
        //            AddressDto address = new AddressDto();
        //            address.PersonId = item.Id;
        //            address.City = model.City;
        //            address.Street = model.Street;

        //            person.AddressList.Add(address);
        //        }
        //        vmp.PersonDtos.Add(person);
        //    }

        //    return vmp.PersonDtos;
        //}
        #endregion
    }
}
