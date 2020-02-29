using ModuloFacturacion.Models.ValueObject.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloFacturacion.Models.Entities
{
    public class Invoice: IAgregateRoot
    {
        public Guid Id { get; set; }
        public NumericNonNegative InvoiceNumber { get; set; }
        public StringNotNull ClientName { get; set; }
        public StringNotNull TaxPayerIdentificationNumber { get; set; }
        public DateTime EmisionDate { get; set; }
        public List<InvoiceDetail> DetailList { set; get; }
        public Invoice(string clientName, string taxPayerIdentificationNumber, List<InvoiceDetail> detailList)
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


}