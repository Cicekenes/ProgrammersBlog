using ProgrammersBlog.Entities.ComplexTypes;
using ProgrammersBlog.Entities.DTOs.UserDTOs;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        IDataResult<ImageDeletedDto> Delete(string pictureName);
        string Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
    }
}
