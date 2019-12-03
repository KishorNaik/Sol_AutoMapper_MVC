using AutoMapper;
using Sol_AutMapper.EF;
using Sol_AutMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_AutMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            base.CreateMap<CustomerModel, CustomerTable>()
                    .ForMember(dest => dest.Street, opts => opts.MapFrom(src => src.Address.Street))
                    .ForMember(dest => dest.City, opts => opts.MapFrom(src => src.Address.City))
                    .ForMember(dest => dest.State, opts => opts.MapFrom(src => src.Address.State));



            base.CreateMap<CustomerTable, CustomerModel>()
                   .ForMember(dest => dest.Address, opts => opts.MapFrom(src => new AddressModel()
                   {
                       City = src.City,
                       State = src.State,
                       Street = src.Street
                   }));
           
        }
    }
}
