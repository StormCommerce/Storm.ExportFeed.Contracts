﻿using System.Collections.Generic;
using System.ServiceModel;
using Enferno.Services.Contracts;

namespace StormCommerce.ExportFeed.Contracts.NotificationServices
{
    [ServiceContract(Name = "ExportProduct", Namespace = "StormCommerce.ExportFeed.Contracts.NotificationServices")]
    public interface IExportProduct
    {
        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        void ProductFeed(Envelope<Header, List<Product>> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        void ProductStatusFeed(Envelope<Header, List<ProductStatus>> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        void CategoryFeed(Envelope<Header, List<ProductCategory>> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        void PromotionFeed(Envelope<Header, List<Promotion>> request);
    }
}