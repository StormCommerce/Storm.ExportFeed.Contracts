using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    public class ProductCategory : Entity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public string DefaultName;
        [DataMember(Order = 4)]
        public string DefaultFullName;
        [DataMember(Order = 5)]
        public int ParentId { get; set; }
        [DataMember(Order = 6)]
        public string ParentCode { get; set; }
    }
}

