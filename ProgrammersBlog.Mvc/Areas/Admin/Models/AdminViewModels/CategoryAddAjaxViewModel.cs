using ProgrammersBlog.Entities.DTOs.CategoryDTOs;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models.AdminViewModels
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryAddDto CategoryAddDto { get; set; }
        public string CategoryAddPartial { get; set; } //Hata vs için. Modelin son durumu için
        public CategoryDto CategoryDto { get; set; } // Category dönüşünde elde edilecek veri
    }
}
