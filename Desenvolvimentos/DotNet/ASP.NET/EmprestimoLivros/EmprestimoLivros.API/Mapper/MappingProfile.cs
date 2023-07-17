using AutoMapper;
using EmprestimoLivros.API.DTO;
using EmprestimoLivros.API.Models;

namespace EmprestimoLivros.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
