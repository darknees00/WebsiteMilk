using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbCategory
    {
        public TbCategory()
        {
            this.tbNews = new HashSet<TbNew>();
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Position { get; set; }
        public string? SeoTitle { get; set; }
        public string? SeoDescription { get; set; }
        public string? SeoKeywords { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedrDate { get; set; }
        public string? ModifierBy { get; set; }
        public ICollection<TbNew> tbNews { get; set; }
        public ICollection<TbPost> tbPosts { get; set; }
    }
}
