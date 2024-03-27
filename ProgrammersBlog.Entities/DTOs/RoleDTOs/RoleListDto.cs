using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.DTOs.RoleDTOs
{
    public class RoleListDto : DtoGetBase
    {
        public IList<Role> Roles { get; set; }
    }
}
