﻿using System;
using System.Collections.Generic;

namespace Laboratorium7b.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        public long InvoiceId { get; set; }
        public long CustomerId { get; set; }
        // public byte[] InvoiceDate { get; set; } = null!;
        public DateTime InvoiceDate { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }

        public string? BillingCountry { get; set; }
        public string? BillingPostalCode { get; set; }
        public decimal Total { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
