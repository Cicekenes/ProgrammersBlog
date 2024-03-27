using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs.UserDTOs
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }
       
    }
}
