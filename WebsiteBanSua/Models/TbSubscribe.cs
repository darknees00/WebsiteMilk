using System;
using System.Collections.Generic;

namespace WebsiteBanSua.Models
{
    public partial class TbSubscribe
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
