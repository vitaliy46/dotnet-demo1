using AutoMapper;
using demo1.Dtos;
using demo1.Models;

namespace demo1.Profiles
{
    public class CustomersProfile : Profile
    {
        // Source -> Target
        public CustomersProfile()
        {
            CreateMap<Customer, CustomerReadDto>();
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>();
        }
    }
}
