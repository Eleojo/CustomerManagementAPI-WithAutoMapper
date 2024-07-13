using AutoMapper;
using Data.Dto;
using Data.Models;

namespace Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<CustomerDto, Customer>().ReverseMap();
            //CreateMap<Customer, CustomerDto>();
            //CreateMap<CustomerDto, Customer>();

        }

       
    }

}
