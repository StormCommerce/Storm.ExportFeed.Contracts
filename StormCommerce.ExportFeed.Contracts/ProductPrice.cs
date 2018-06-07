using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    public class ProductPrice : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string Currency { get; set; }
        [DataMember(Order = 3)]
        public decimal Price { get; set; }
        [DataMember(Order = 4)]
        public decimal? OriginalPrice { get; set; } 
        [DataMember(Order = 5)]
        public decimal VatRate { get; set; }   //e.g. 25% vatrate shall be set here as 0.25
        [DataMember(Order = 6)]
        public bool IsActive { get; set; }
        [DataMember(Order = 7)]
        public List<string> AvailableOnLocations { get; set; }
        [DataMember(Order = 8)]
        public string SalesArea { get; set; }
    }
}
