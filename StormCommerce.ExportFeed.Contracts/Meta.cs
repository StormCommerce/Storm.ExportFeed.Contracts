using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts
{
    public class Meta : Entity
    {
        [DataMember(Order = 1)]
        public List<MetaParametric> MetaParametrics { get; set; }
    }


    public class MetaParametric : Entity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public ParametricType Type { get; set; }
        [DataMember(Order = 4)]
        public string DefaultName { get; set; }
        [DataMember(Order = 5)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 6)]
        public string DefaultUnitOfMeasurement { get; set; }
        [DataMember(Order = 7)]
        public List<ParametricCulture> Cultures { get; set; }    
        [DataMember(Order = 8)]
        public ParametricDefaultValueList ValueList { get; set; }
        [DataMember(Order = 9)]
        public List<ParametricValueList> MultipleValueList { get; set; }
    }

    public class ParametricDefaultValueList : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string DefaultValue { get; set; }
        [DataMember(Order = 3)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 4)]
        public List<CultureValue> Cultures { get; set; }
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

    public class ParametricValueList : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string DefaultValue { get; set; }
        [DataMember(Order = 3)]
        public string DefaultDescription { get; set; }
        [DataMember(Order = 4)]
        public List<CultureValue> Cultures { get; set; }
    }
}
