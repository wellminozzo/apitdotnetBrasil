using AutoMapper;
using brasilApi.Dtos;
using BrasilApi.Models;

namespace brasilApi.Mappings
{
    
    public class EnderecoMapping : Profile
    {

        public EnderecoMapping()
        {

            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();


        }
        

    }

}
 