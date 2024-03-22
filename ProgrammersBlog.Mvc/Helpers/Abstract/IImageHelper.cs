using ProgrammersBlog.Entities.DTOs.UserDTOs;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        IDataResult<ImageDeletedDto> Delete(string pictureName);
        Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
    }
}
