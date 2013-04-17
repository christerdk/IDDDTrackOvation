using System;
using System.Collections.Generic;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model.Services
{
    public class ProductDefectStatistics
    {
         public IList<Product> AllProductsOfTenant(TenantId tenantId)
         {
             return null;
         }

        public ProductId MostDefectiveProduct()
        {
            return new ProductId(Guid.Empty);
        }

    }
}