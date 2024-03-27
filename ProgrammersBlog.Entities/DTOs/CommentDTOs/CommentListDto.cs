using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs.CommentDTOs
{
    public class CommentListDto : DtoGetBase
    {
        public IList<Comment> Comments { get; set; }
    }
}
