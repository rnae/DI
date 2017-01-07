using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProductService
    {
        private readonly ProductRepository _repository;

        // Constructor injection
        public ProductService(ProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            // save dependency for later use
            _repository = repository;
        }


        public IEnumerable<Product> GetFeaturedProducts()
        {
            // Add business logic in here if is needed
            var products = _repository.GetFeaturedProducts();
            return products.ToList().OrderBy(p=> p.Title);
        }
    }
}
