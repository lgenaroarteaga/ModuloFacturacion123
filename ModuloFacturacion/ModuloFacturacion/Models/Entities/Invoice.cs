using ModuloFacturacion.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloFacturacion.Models.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public NumericNonNegative InvoiceNumber { get; set; }
        public StringNotNull ClientName { get; set; }
        public NumericNonNegative TaxPayerIdentificationNumber { get; set; }
        public DateTime EmisionDate { get; set; }

        public List<InvoiceDetail> DetailList { set; get; }

        public Invoice(string clientName, int taxPayerIdentificationNumber, List<InvoiceDetail> detailList)
        {
            Id = new Guid();
            ClientName = clientName;
            TaxPayerIdentificationNumber = taxPayerIdentificationNumber;
            DetailList = detailList;
        }

        public void addToDetailList(InvoiceDetail invoiceDetail) {
            DetailList.Add(invoiceDetail);
        }
    }

    public class InvoiceDetail {
        public Guid Id { get; set; }
        public StringNotNull Detail { set; get; }
        public DecimalNonNegative UnitaryCost { set; get; }
        public NumericNonNegative Amount { set; get; }

        public InvoiceDetail(string detail, decimal unitaryCost, int amount) {
            Id = new Guid();
            Detail = detail;
            UnitaryCost = unitaryCost;
            Amount = amount;
        }
    }
}