using ModuloFacturacion.Models.ValueObject.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloFacturacion.Models.Entities
{
    public class Authorization
    {
        public Guid Id { get; set; }
        public NumericString AuthorizationNumber { set; get; } 
        public NumericString TaxEmitterNumber { set; get; }
        public StringNotNull Name { set; get; }
        public NumericNonNegative LastEmmitedNumber { set; get; }
        public DateTime ExpirationDate { set; get; }
        public Authorization(string authorizationNumber, string taxEmitterNumber, string name, int lastEmittedNumber, DateTime expirationDate ) {
            Id = new Guid();
            AuthorizationNumber = authorizationNumber;
            TaxEmitterNumber = taxEmitterNumber;
            Name = name;
            LastEmmitedNumber = lastEmittedNumber;
            ExpirationDate = expirationDate;
        }
    }
}