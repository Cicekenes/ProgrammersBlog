using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs.UserDTOs
{
    public class ImageUploadedDto : DtoGetBase
    {
        public string FullName { get; set; } //resim adı
        public string OldName { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string FolderName { get; set; }
        public long Size { get; set; }
    }
}
