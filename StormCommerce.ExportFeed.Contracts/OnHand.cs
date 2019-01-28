using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    public class OnHand : Entity
    {
        [DataMember(Order = 1)]
        public decimal Value { get; set; }
        [DataMember(Order = 2)]
        public string LocationCode { get; set; }
        [DataMember(Order = 3)]
        public int? LeadTimeDayCount { get; set; }
        [DataMember(Order = 4)]
        public List<string> AvailableOnStores { get; set; }
        [DataMember(Order = 5)]
        public List<string> ConnectedPriceLists { get; set; }
		[DataMember(Order = 6)]
		public DateTime NextDeliveryDate { get; set; }
    }
}
