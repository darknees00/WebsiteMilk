using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbOrderDertail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public virtual TbOrder TbOrder { get; set; }
        public virtual TbProduct TbProduct { get; set; }
    }
}
