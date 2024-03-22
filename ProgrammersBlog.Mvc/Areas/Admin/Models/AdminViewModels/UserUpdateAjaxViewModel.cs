using ProgrammersBlog.Entities.DTOs.UserDTOs;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models.AdminViewModels
{
    public class UserUpdateAjaxViewModel
    {
        public UserUpdateDto UserUpdateDto { get; set; }
        public string UserUpdatePartial { get; set; } //Hata vs için. Modelin son durumu için
        public UserDto UserDto { get; set; } // User dönüşünde elde edilecek veri
    }
}
