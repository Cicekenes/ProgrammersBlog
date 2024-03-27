using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
        public virtual int CurrentPage { get; set; } = 1;
        public virtual int PageSize { get; set; } = 5;
        public virtual int TotalCount { get; set; } //toplam makale gibi
        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));// toplam sayfa
        public virtual bool ShowPrevious => CurrentPage > 1; //önceki sayfa var mı
        public virtual bool ShowNext => CurrentPage < TotalPages; // sonraki sayfa var mı
        public virtual bool IsAscending { get; set; } = false;

    }
}
