using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        //public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
        public string Text { get; set; } //Yorum
        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
