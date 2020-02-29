﻿using ModuloFacturacion.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloFacturacion.Models.Entities
{
    public class InvoiceDetail
    {
        public Guid Id { get; set; }
        public StringNotNull Detail { set; get; }
        public DecimalNonNegative UnitaryCost { set; get; }
        public NumericNonNegative Amount { set; get; }

        public InvoiceDetail(string detail, decimal unitaryCost, int amount)
        {
            Id = new Guid();
            Detail = detail;
            UnitaryCost = unitaryCost;
            Amount = amount;
        }
    }
}