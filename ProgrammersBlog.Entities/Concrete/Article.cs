using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.Concrete
{
    /// <summary>
    /// Makale
    /// </summary>
    public class Article : EntityBase, IEntity
    {
        public string Title { get; set; } // Başlık
        public string Content { get; set; } //İçerik
        public string Thumbnail { get; set; } //Resim
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; } = 0; //Okunma sayısı
        public int CommentCount { get; set; } = 0; //Yorum sayısı
        public string SeoAuthor { get; set; } //Meta taglarının ekleneceği kısım.
        public string SeoDescription { get; set; } //Seo açıklama
        public string SeoTags { get; set; } //Seo tagları
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
