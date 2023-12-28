using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbProduct
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? ProductCategoryId { get; set; }
        public string? Description { get; set; }
        public string? Detail { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceSale { get; set; }
        public int? Quantity { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedrDate { get; set; }
        public string? ModifierBy { get; set; }
        public virtual TbProductCategory TbProductCategory { get; set; }
        public virtual ICollection<TbOrderDertail> TbOrderDertails { get; set; }
    }
}
