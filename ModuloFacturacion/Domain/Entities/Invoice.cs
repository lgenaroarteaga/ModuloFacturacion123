using Domain.ValueObject;
using Framework.Aggregate;
using ModuloFacturacion.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloFacturacion.Models.Entities
{
    public class Invoice: AggregateRoot<InvoiceGuid>
    {
        public Guid Id { get; set; }
        public NumericNonNegative InvoiceNumber { get; set; }
        public StringNotNull ClientName { get; set; }
        public StringNotNull TaxPayerIdentificationNumber { get; set; }
        public DateTimeType EmisionDate { get; set; }
        public List<InvoiceDetail> DetailList { set; get; }
        public Authorization Authorization { get; set; }

        public Invoice(string clientName, string taxPayerIdentificationNumber, List<InvoiceDetail> detailList, Authorization authorization)
        {
            Id = new Guid();
            ClientName = clientName;
            TaxPayerIdentificationNumber = taxPayerIdentificationNumber;
            DetailList = detailList;
            EmisionDate = DateTime.Now;
            Authorization = authorization;
            InvoiceNumber = authorization.LastEmmitedNumber.Value + 1;
        }

        public void AddToDetailList(InvoiceDetail invoiceDetail) {
            DetailList.Add(invoiceDetail);
        }

        public override void When(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }

        protected override void ValidateStatus()
        {
            throw new NotImplementedException();
        }
    }


}