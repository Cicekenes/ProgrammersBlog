using AutoMapper;
using ProgrammersBlog.Entities.ComplexTypes;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.DTOs.UserDTOs;
using ProgrammersBlog.Mvc.Helpers.Abstract;

namespace ProgrammersBlog.Mvc.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile(IImageHelper imageHelper)
        {
            CreateMap<UserAddDto, User>().ForMember(dest=>dest.Picture,opt=>opt.MapFrom(x=>imageHelper.Upload(x.UserName,x.PictureFile,PictureType.User,null))).ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}
