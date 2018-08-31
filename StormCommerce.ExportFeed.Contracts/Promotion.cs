using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StormCommerce.ExportFeed.Contracts
{
    [DataContract]
    public enum RequirementType
    {
        [EnumMember(Value = "CustomerFlag")]
        CustomerFlag = 1,
        [EnumMember(Value = "BasketPRoducts")]
        BasketProducts = 3,
        [EnumMember(Value = "NumberOfProductsInBasket")]
        NumberOfProductsInBasket = 5,
        [EnumMember(Value = "BaksetTotalAbove")]
        BasketTotalAbove = 6,
        [EnumMember(Value = "Campaign")]
        Campaign = 9,
        [EnumMember(Value = "CheckoutCode")]
        CheckoutCode = 10,
        [EnumMember(Value = "ActivatedPriceList")]
        ActivatedPriceList = 12,
        [EnumMember(Value = "ProductFlag")]
        ProductFlag = 13,
        [EnumMember(Value = "RequireCompany")]
        RequireCompany = 14,
        [EnumMember(Value = "RequireOrExcludeCompanyFlag")]
        RequireOrExcludeCompanyFlag = 17
    }

    [DataContract]
    public enum EffectType
    {
        [EnumMember(Value = "DiscountBasket")]
        DiscountBasket = 1,
        [EnumMember(Value = "SelectProducts")]
        SelectProducts = 2,
        [EnumMember(Value = "DiscountProducts")]
        DiscountProducts = 4,
        [EnumMember(Value = "AddProducts")]
        AddProducts = 5,
        [EnumMember(Value = "DiscountFreight")]
        DiscountFreight = 6,
        [EnumMember(Value = "ActivatePriceList")]
        ActivatePriceList = 8
    }

    [DataContract]
    public class Promotion
    {
        [DataMember(Order = 1)]
        public string DefaultName { get; set; }
        [DataMember(Order = 2)]
        public string DefaultSubHeader { get; set; }
        [DataMember(Order = 3)]
        public string DefaultSubDescription { get; set; }
        [DataMember(Order = 4)]
        public string DefaultDescriptionHeader { get; set; }
        [DataMember(Order = 5)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 6)]
        public bool IsBundle { get; set; }
        [DataMember(Order = 7)]
        public bool IsStackable { get; set; }
        [DataMember(Order = 8)]
        public int? AllowedUsageCount { get; set; }
        [DataMember(Order = 9)]
        public int? UsageCount { get; set; }
        [DataMember(Order = 10)]
        public int? UniqueUsageCount { get; set; }
        [DataMember(Order = 11)]
        public DateTime? StartDate { get; set; }
        [DataMember(Order = 12)]
        public DateTime? EndDate { get; set; }
        [DataMember(Order = 13)]
        public int TemplateId { get; set; }
        [DataMember(Order = 14)]
        public bool IsActive { get; set; }
        [DataMember(Order = 15)]
        public DateTime? StoppedDate { get; set; }
        [DataMember(Order = 16)]
        public bool ExcludeFromPriceCalculation { get; set; }
        [DataMember(Order = 17)]
        public bool IsProductReq { get; set; }
        [DataMember(Order = 18)]
        public bool? IsSynchronized { get; set; }
        [DataMember(Order = 19)]
        public string ExternalCode { get; set; }
        [DataMember(Order = 20)]
        public List<Requirement> Requirements { get; set; }
        [DataMember(Order = 21)]
        public List<Effect> Effects { get; set; }
    }

    [DataContract]
    public class Requirement
    {
        [DataMember(Order = 1)]
        public RequirementType Type { get; set; }
        [DataMember(Order = 2)]
        public int? CustomerFlagId { get; set; }
        [DataMember(Order = 3)]
        public bool? IsProductIncluded { get; set; }
        [DataMember(Order = 4)]
        public bool? IsInclusive { get; set; }
        [DataMember(Order = 5)]
        public decimal? ProductValue { get; set; }
        [DataMember(Order = 6)]
        public bool? IsIncVat { get; set; }
        [DataMember(Order = 7)]
        public decimal? OrderSum { get; set; }
        [DataMember(Order = 8)]
        public decimal? OrderSumMax { get; set; }
        [DataMember(Order = 9)]
        public string CheckoutCode { get; set; }
        [DataMember(Order = 10)]
        public int SortOrder { get; set; }
        [DataMember(Order = 11)]
        public bool IsActive { get; set; }
        [DataMember(Order = 12)]
        public List<RequirementProductList> ProductLists { get; set; }
    }

    [DataContract]
    public class RequirementProductList
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public int Quantity { get; set; }
        [DataMember(Order = 3)]
        public string ManufacturerCode { get; set; }
        [DataMember(Order = 4)]
        public string CategoryCode { get; set; }
        [DataMember(Order = 5)]
        public string PartNo { get; set; }
        [DataMember(Order = 6)]
        public string PriceListCode { get; set; }
        [DataMember(Order = 7)]
        public string FlagCode { get; set; }
        [DataMember(Order = 8)]
        public decimal? PriceSale { get; set; }
        [DataMember(Order = 9)]
        public bool? IsIncVat { get; set; }
    }

    [DataContract]
    public class Effect
    {
        [DataMember(Order = 1)]
        public EffectType Type { get; set; }
        [DataMember(Order = 2)]
        public decimal? GenericDiscountPct { get; set; }
        [DataMember(Order = 3)]
        public int SortOrder { get; set; }
        [DataMember(Order = 4)]
        public decimal? FixedDiscount { get; set; }
        [DataMember(Order = 5)]
        public bool? IsFixedDiscountIncVat { get; set; }
        [DataMember(Order = 6)]
        public bool IgnoreNonDiscountable { get; set; }
        [DataMember(Order = 7)]
        public bool IsActive { get; set; }
        [DataMember(Order = 8)]
        public List<EffectProductList> ProductLists { get; set; }
    }

    [DataContract]
    public class EffectProductList
    {
        [DataMember(Order = 1)]
        public int? Quantity { get; set; }
        [DataMember(Order = 2)]
        public string ManufacturerCode { get; set; }
        [DataMember(Order = 3)]
        public string CategoryCode { get; set; }
        [DataMember(Order = 4)]
        public string PartNo { get; set; }
        [DataMember(Order = 5)]
        public string PriceListCode { get; set; }
        [DataMember(Order = 6)]
        public decimal? PriceSale { get; set; }
        [DataMember(Order = 7)]
        public decimal? DiscountPct { get; set; }
    }
}
