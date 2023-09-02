using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models;

public partial class Invoice
{
    [Key]
    [Column("InvoiceID")]
    public int InvoiceId { get; set; }

    public int AccountNumber { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal PowerUsage { get; set; }

    [Column(TypeName = "money")]
    public decimal InvoiceTotal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("Invoices")]
    public virtual Customer AccountNumberNavigation { get; set; } = null!;
}
