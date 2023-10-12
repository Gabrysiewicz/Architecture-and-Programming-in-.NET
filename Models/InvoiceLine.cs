using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium7b.Models
{
    public partial class InvoiceLine
    {
        [Display(Name = "Invoice Line Id")]
        public long InvoiceLineId { get; set; }

        [Display(Name = "Invoice Id")]
        public long InvoiceId { get; set; }

        [Display(Name = "Track Id")]
        public long TrackId { get; set; }

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Quantity")]
        public long Quantity { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Track Track { get; set; } = null!;
    }
}
