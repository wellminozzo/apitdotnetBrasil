using AutoMapper;
using brasilApi.Dtos;
using BrasilApi.Dtos;
using BrasilApi.Models;

namespace brasilApi.Mappings
{

    public class  BancoMapping : Profile
    {

        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();

        }   

    }  

}