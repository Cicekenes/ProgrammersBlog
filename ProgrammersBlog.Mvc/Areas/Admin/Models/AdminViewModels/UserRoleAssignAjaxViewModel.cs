using ProgrammersBlog.Entities.DTOs.RoleDTOs;
using ProgrammersBlog.Entities.DTOs.UserDTOs;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models.AdminViewModels
{
    public class UserRoleAssignAjaxViewModel
    {
        public UserRoleAssignDto UserRoleAssignDto { get; set; }
        public string RoleAssignPartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
