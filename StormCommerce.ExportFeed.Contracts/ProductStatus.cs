using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    [DataContract]
    public class ProductStatus : Entity
    {
        [DataMember(Order = 1)]
        public string PartNo { get; set; }

        [DataMember(Order = 2)]
        public Status Status { get; set; }

        [DataMember(Order = 3)]
        public bool Buyable { get; set; }

        [DataMember(Order = 4)]
        public List<OnHand> OnHands { get; set; }

        [DataMember(Order = 5)]
        public List<ProductPrice> ProductPrices { get; set; }

        [DataMember(Order = 6)]
        public int? SupplierLeadTime { get; set; }
    }
}
