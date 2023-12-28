using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbNew
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? CategoryId { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceSale { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedrDate { get; set; }
        public string? ModifierBy { get; set; }
        public virtual TbCategory Category { get; set; }
    }
}
