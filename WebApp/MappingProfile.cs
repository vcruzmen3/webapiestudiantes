using AutoMapper;
using Domain.Models;
using WebApp.models;

namespace WebApp
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentPost, Student>();
        }
    }
}
