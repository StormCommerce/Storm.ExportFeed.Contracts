using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    [DataContract]
    public enum Status
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
        [EnumMember(Value = "Active")]
        Active = 1,
        [EnumMember(Value = "Coming")]
        Coming = 2,
        [EnumMember(Value = "Expiring")]
        Expiring = 3,
        [EnumMember(Value = "Hidden")]
        Hidden = 4,
        [EnumMember(Value = "Inactive")]
        Inactive = 5,
        [EnumMember(Value = "NotActivated")]
        NotActivated = 6
    }

    [DataContract(Namespace = "StormCommerce.ExportFeed.Contracts")]
    public class Envelope<T1, T2> 
    {
        [DataMember(Order = 1)]
        public T1 Header { get; set; }

        [DataMember(Order = 2)]
        public T2 Body { get; set; }
    }

    public class Header : Entity
    {
        [DataMember(Order = 1)]
        public int ApplicationId { get; set; }
        [DataMember(Order = 2)]
        public int ExportNumber { get; set; }
        [DataMember(Order = 3)]
        public string ImageUrl { get; set; }
        [DataMember(Order = 4)]
        public Guid? FullUpdate { get; set; }
        [DataMember(Order = 5)]
        public bool? FullStop { get; set; }
        [DataMember(Order = 6)]
        public string BaseImageUrl { get; set; }
    }
}
