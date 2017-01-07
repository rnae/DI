using System;
using System.Collections.Generic;
using BLL;

namespace DAL
{
    public class SqlProductRepository: ProductRepository
    {
        public override IEnumerable<Product> GetFeaturedProducts()
        {
            // Here we call the ORM
            // Convert ORM data to domain entity
            throw new NotImplementedException();
        }
    }
}
