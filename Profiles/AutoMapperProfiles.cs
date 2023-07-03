using AutoMapper;
using StudentAPI.DTO;
using StudentAPI.Models;

namespace StudentAPI.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDto>().ReverseMap();

            CreateMap<Gender, GenderDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();
            
        }
    }
}
