using ProgrammersBlog.Entities.DTOs.UserDTOs;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models.AdminViewModels
{
    public class UserAddAjaxViewModel
    {
        public UserAddDto UserAddDto { get; set; }
        public string UserAddPartial { get; set; } //Hata vs için. Modelin son durumu için
        public UserDto UserDto { get; set; } // User dönüşünde elde edilecek veri
    }
}
