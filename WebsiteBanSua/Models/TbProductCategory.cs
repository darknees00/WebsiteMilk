using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbProductCategory
    {
        public TbProductCategory()
        {
            this.tbProducts = new HashSet<TbProduct>();
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedrDate { get; set; }
        public string? ModifierBy { get; set; }
        public ICollection<TbProduct> tbProducts { get; set; }
    }
}
