using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbOrder
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? CustomerName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedrDate { get; set; }
        public string? ModifierBy { get; set; }
        public virtual ICollection<TbOrderDertail> TbOrderDertails { get; set; }
    }
}
