using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    [DataContract]
    public enum RelationType
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
        [EnumMember(Value = "CheckoutofferAccessory")]
        CheckoutofferAccessory = 1,
        [EnumMember(Value = "FocusAccessory")]
        FocusAccessory = 2,
        [EnumMember(Value = "StandardAccessory")]
        StandardAccessory = 3,
        [EnumMember(Value = "HiddenAccessory")]
        HiddenAccessory = 4,
        [EnumMember(Value = "ServiceAccessory")]
        ServiceAccessory = 5,
        [EnumMember(Value = "InsuranceAccessory")]
        InsuranceAccessory = 6,
        [EnumMember(Value = "SimilarAccessory")]
        SimilarAccessory = 7,
        [EnumMember(Value = "ReplacementProductAccessory")]
        ReplacementProductAccessory = 8,
        [EnumMember(Value = "FeeAccessory")]
        FeeAccessory = 9,
        [EnumMember(Value = "Upsell")]
        Upsell = 101,
        [EnumMember(Value = "CrossSell")]
        CrossSell = 102,
    }

    [DataContract]
    public enum FileType
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
        [EnumMember(Value = "GalleryImage")]
        GalleryImage = 1,
        [EnumMember(Value = "ExternalImage")]
        ExternalImage = 2,
        [EnumMember(Value = "Embedded")]
        Embedded = 3,
        [EnumMember(Value = "Azure")]
        Azure = 4,
    }

    [DataContract]
    public enum FileFormat
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
        [EnumMember(Value = "Jpg")]
        Jpg = 1,
        [EnumMember(Value = "Gif")]
        Gif = 2,
        [EnumMember(Value = "Mp4")]
        Mp4 = 3,
        [EnumMember(Value = "Pdf")]
        Pdf = 4,
    }

    [DataContract]
    public enum ParametricType
    {
        [EnumMember(Value = "Unknown")]
        Unknown = 0,
        [EnumMember(Value = "Text")]
        Text = 1,
        [EnumMember(Value = "Integer")]
        Integer = 2,
        [EnumMember(Value = "Decimal")]
        Decimal = 3,
        [EnumMember(Value = "Boolean")]
        Boolean = 4,
        [EnumMember(Value = "Html")]
        Html = 5,
        [EnumMember(Value = "Date")]
        Date = 6,
        [EnumMember(Value = "List")]
        List = 101,
        [EnumMember(Value = "Multiple")]
        Multiple = 102
    }

    [DataContract]
    public enum VariantType
    {
        [EnumMember(Value = "Standard")]
        Standard = 1,
        [EnumMember(Value = "Refurbished")]
        Refurbished = 2,
        [EnumMember(Value = "Freight")]
        Freight = 3,
        [EnumMember(Value = "Insurance")]
        Insurance = 4,
        [EnumMember(Value = "GiftCertificate")]
        GiftCertificate = 5,
        [EnumMember(Value = "Bid")]
        Bid = 6,
        [EnumMember(Value = "Download")]
        Download = 7,
        [EnumMember(Value = "Structure")]
        Structure = 8,
        [EnumMember(Value = "Invoice")]
        Invoice = 9,
        [EnumMember(Value = "Demo")]
        Demo = 10,
        [EnumMember(Value = "Service")]
        Service = 11,
        [EnumMember(Value = "Installation")]
        Installation = 12,
        [EnumMember(Value = "Accumulation")]
        Accumulation = 13,
        [EnumMember(Value = "ExtendedAssortment")]
        ExtendedAssortment = 14,
        [EnumMember(Value = "ERPExtended")]
        ERPExtended = 15,
        [EnumMember(Value = "ERPStandardNoStock")]
        ERPStandardNoStock = 16,
        [EnumMember(Value = "ERPPackage")]
        ERPPackage = 17,
        [EnumMember(Value = "Donations")]
        Donations = 18,
        [EnumMember(Value = "ERPTempOUtOfStock")]
        ERPTempOUtOfStock = 19,
        [EnumMember(Value = "EnvironmentalFee")]
        EnvironmentalFee = 20,
        [EnumMember(Value = "PackingFee")]
        PackingFee = 21,
        [EnumMember(Value = "Configuration")]
        Configuration = 22,
        [EnumMember(Value = "StructureWithoutCalc")]
        StructureWithoutCalc = 23,
        [EnumMember(Value = "ERPPackageWithCalc")]
        ERPPackageWithCalc = 24,
        [EnumMember(Value = "DisplayOnly")]
        DisplayOnly = 25,
        [EnumMember(Value = "ERPDownload")]
        ERPDownload = 26,
        [EnumMember(Value = "ERPDownloadNoStock")]
        ERPDownloadNoStock = 27,
        [EnumMember(Value = "ERPDownloadTempNoStock")]
        ERPDownloadTempNoStock = 28,
        [EnumMember(Value = "ERPStandard2")]
        ERPStandard2 = 29,
        [EnumMember(Value = "Standard2")]
        Standard2 = 30,
        [EnumMember(Value = "ERPStandardNoStock2")]
        ERPStandardNoStock2 = 31,
        [EnumMember(Value = "ERPTempOutOfStock2")]
        ERPTempOutOfStock2 = 32,
        [EnumMember(Value = "License")]
        License = 33,
        [EnumMember(Value = "CentRounding")]
        CentRounding = 34,
        [EnumMember(Value = "SalesTax")]
        SalesTax = 35,
        [EnumMember(Value = "FreightStructure")]
        FreightStructure = 36
    }

    public class Product : Entity
    {
        [DataMember(Order = 1)]
        public int? Id { get; set; }  // (=VariantId in db)
        [DataMember(Order = 2)]
        public string Code { get; set; } // (=VariantCode in db)
        [DataMember(Order = 3)]
        public List<Category> Categories { get; set; }
        [DataMember(Order = 4)]
        public string CommodityCode { get; set; }
        [DataMember(Order = 5)]
        public Manufacturer Manufacturer { get; set; }
        [DataMember(Order = 6)]
        public List<Variant> Variants { get; set; }
        [DataMember(Order = 7)]
        public List<Parametric> Parametrics { get; set; }
        [DataMember(Order = 8)]
        public string ImageKey { get; set; }
        [DataMember(Order = 9)]
        public List<ProductCulture> ProductCultures { get; set; }
        [DataMember(Order = 10)]
        public List<Relation> Relations { get; set; }
        [DataMember(Order = 11)]
        public List<Flag> Flags { get; set; }
        [DataMember(Order = 12)]
        public List<Family> Families { get; set; }
        [DataMember(Order = 13)]
        public List<File> Files { get; set; }
        [DataMember(Order = 14)]
        public Popularity Popularity { get; set; }
        [DataMember(Order = 15)]
        public string DefaultName { get; set; }
        [DataMember(Order = 16)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 17)]
        public string DefaultSubDescription { get; set; }
        [DataMember(Order = 18)]
        public string DefaultDescriptionHeader { get; set; }
        [DataMember(Order = 19)]
        public string DefaultSubHeader { get; set; }
        [DataMember(Order = 20)]
        public string DefaultSynonyms { get; set; }
        [DataMember(Order = 21)]
        public string DefaultUniqueUrlName { get; set; }
        [DataMember(Order = 22)]
        public string DefaultMetaDescription { get; set; }
        [DataMember(Order = 23)]
        public string DefaultMetaTags { get; set; }
	    [DataMember(Order = 24)]
	    public int? PrimaryCategory { get; set; }
	    [DataMember(Order = 25)]
	    public int? ViewCount { get; set; }
	}

    public class Popularity : Entity
    {
        [DataMember(Order = 1)]
        public string Source { get; set; }
        [DataMember(Order = 2)]
        public int CategoryRank { get; set; }
        [DataMember(Order = 3)]
        public int CategoryRankMax { get; set; }
        [DataMember(Order = 4)]
        public int TotalRank { get; set; }
    }

    public class Family : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string DefaultName { get; set; }
        [DataMember(Order = 3)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 4)]
        public List<CultureName> Cultures { get; set; }
    }

    public class Relation : Entity
    {
        [DataMember(Order = 1)]
        public RelationType Type { get; set; }
        [DataMember(Order = 1)]
        public string PartNo { get; set; }
    }

    public class Category : Entity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; } // För att code är inget fält vi kräver
        [DataMember(Order = 2)]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public string DefaultName;
        [DataMember(Order = 4)]
        public string DefaultFullName;
        [DataMember(Order = 5)]
        public string DefaultSynonyms;
        [DataMember(Order = 6)]
        public List<CategoryCulture> Cultures { get; set; }
    }

    public class CategoryCulture : Entity
    {
        [DataMember(Order = 1)]
        public string CultureCode;
        [DataMember(Order = 2)]
        public string Name;
        [DataMember(Order = 3)]
        public string FullName;
        [DataMember(Order = 4)]
        public string Synonyms;
    }

    public class Manufacturer : Entity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public string Name;
        [DataMember(Order = 4)]
        public string Description;
        [DataMember(Order = 5)]
        public string LogoKey { get; set; }
    }

    public class Variant : Entity
    {
        [DataMember(Order = 1)]
        public List<Parametric> VariantDefiningParametrics { get; set; }
        [DataMember(Order = 2)]
        public string PartNo { get; set; }
        [DataMember(Order = 3)]
        public string ManufacturerPartNo { get; set; }
        [DataMember(Order = 4)]
        public string EanCode { get; set; }
        [DataMember(Order = 5)]
        public List<OnHand> OnHands { get; set; }
        [DataMember(Order = 6)]
        public Status Status { get; set; }
        [DataMember(Order = 7)]
        public string ImageKey { get; set; }
        [DataMember(Order = 8)]
        public DateTime? StartDate { get; set; }
        [DataMember(Order = 9)]
        public bool Buyable { get; set; }
        [DataMember(Order = 10)]
        public List<ProductPrice> ProductPrices { get; set; }
        [DataMember(Order = 11)]
        public List<CultureName> Names { get; set; }
        [DataMember(Order = 12)]
        public List<Parametric> Parametrics { get; set; }
        [DataMember(Order = 13)]
        public List<Relation> Relations { get; set; }
        [DataMember(Order = 14)]
        public List<Flag> Flags { get; set; }
        [DataMember(Order = 15)]
        public Logistic Logistic { get; set; }
        [DataMember(Order = 16)]
        public List<File> Files { get; set; }
        [DataMember(Order = 17)]
        public string FreightClass { get; set; }
        [DataMember(Order = 18)]
        public int ProductId { get; set; }
        [DataMember(Order = 19)]
        public string DefaultName { get; set; }
        [DataMember(Order = 20)]
        public string DefaultUniqueUrlName { get; set; }
        [DataMember(Order = 21)]
        public int? SupplierLeadTimeDayCount { get; set; }
        [DataMember(Order = 22)]
        public decimal? RecommendedQuantity { get; set; }
        [DataMember(Order = 23)]
        public bool? IsRecommendedQuantityFixed { get; set; }
        [DataMember(Order = 24)]
        public VariantType Type { get; set; }   
        [DataMember(Order = 25)]
        public int? ViewCount { get; set; }
    }

    public class File : Entity
    {
        [DataMember(Order = 1)]
        public FileType Type { get; set; }
        [DataMember(Order = 2)]
        public FileFormat Format { get; set; }
        [DataMember(Order = 3)]
        public string Url { get; set; }
        [DataMember(Order = 4)]
        public string Code { get; set; }
    }

    public class Logistic : Entity  //Unit: cm, kg
    {
        [DataMember(Order = 1)]
        public decimal? Width { get; set; }
        [DataMember(Order = 2)]
        public decimal? Height { get; set; }
        [DataMember(Order = 3)]
        public decimal? Depth { get; set; }
        [DataMember(Order = 3)]
        public decimal? Weight { get; set; }
    }

    public class Flag : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string DefaultName { get; set; }
        [DataMember(Order = 3)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 4)]
        public string Value { get; set; }
        [DataMember(Order = 5)]
        public List<CultureName> Cultures { get; set; }
    }

    public class CultureValue : Entity
    {
        [DataMember(Order = 1)]
        public string CultureCode;
        [DataMember(Order = 2)]
        public string Value;
        [DataMember(Order = 3)]
        public string Description { get; set; }
    }

    public class CultureName : Entity
    {
        [DataMember(Order = 1)]
        public string CultureCode;
        [DataMember(Order = 2)]
        public string Name;
        [DataMember(Order = 3)]
        public string Description { get; set; }
    }

    public class Parametric : Entity
    {
        [DataMember(Order = 1)]
        public ParametricType Type { get; set; }
        [DataMember(Order = 2)]
        public string DefaultName { get; set; }
        [DataMember(Order = 3)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 4)]
        public string DefaultUnitOfMeasurement { get; set; }
        [DataMember(Order = 5)]
        public List<ParametricCulture> Cultures { get; set; }
        [DataMember(Order = 6)]
        public string Code { get; set; }
        [DataMember(Order = 7)]
        public string Value { get; set; } // Multiple value parametrics are concatenated with comma
        [DataMember(Order = 8)]
        public List<CultureValue> CultureValues { get; set; } // Multiple value parametrics are concatenated with comma
        [DataMember(Order = 9)]
        public ParametricValueList ValueList { get; set; }
        [DataMember(Order = 10)]
        public List<ParametricValueList> MultipleValueList { get; set; }
        [DataMember(Order = 21)]
        public int Id { get; set; }
    }

    public class ParametricValueList : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string DefaultValue { get; set; }
        [DataMember(Order = 3)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 4)]
        public List<ParametricValueListCulture> Cultures { get; set; }
    }

    public class ParametricValueListCulture : Entity
    {
        [DataMember(Order = 1)]
        public string CultureCode { get; set; }
        [DataMember(Order = 2)]
        public string Value { get; set; }
        [DataMember(Order = 3)]
        public string Description { get; set; }
    }
    public class ProductCulture : Entity
    {
        [DataMember(Order = 1)]
        public string CultureCode { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Description { get; set; }
        [DataMember(Order = 4)]
        public string SubDescription { get; set; }
        [DataMember(Order = 5)]
        public string DescriptionHeader { get; set; }
        [DataMember(Order = 6)]
        public string SubHeader { get; set; }
        [DataMember(Order = 7)]
        public string Synonyms { get; set; }
        [DataMember(Order = 8)]
        public string UniqueUrl { get; set; }
        [DataMember(Order = 9)]
        public string MetaDescription { get; set; }
        [DataMember(Order = 10)]
        public string MetaTags { get; set; }
    }

    public class ParametricCulture : Entity
    {
        [DataMember(Order = 1)]
        public string CultureCode { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Description { get; set; }
        [DataMember(Order = 4)]
        public string UnitOfMeasurement { get; set; }
    }
}