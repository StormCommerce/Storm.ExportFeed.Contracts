﻿using System;
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
    }

    public class Popularity
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

    public class Family
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

    public class Relation
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
        public List<PriceList> PriceLists { get; set; }
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
        public List<CultureName> Units { get; set; }
        [DataMember(Order = 18)]
        public List<File> Files { get; set; }
        [DataMember(Order = 19)]
        public string FreightClass { get; set; }
        [DataMember(Order = 20)]
        public int ProductId { get; set; }
        [DataMember(Order = 21)]
        public string DefaultName { get; set; }
    }

    public class File
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

    public class Logistic   //Unit: cm, kg
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
