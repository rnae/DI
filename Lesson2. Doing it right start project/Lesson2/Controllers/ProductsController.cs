using System;
using System.Web.Http;
using BLL;
using Lesson2.Mappers;

namespace Lesson2.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ProductRepository _repository;

        // Constructor injection
        private ProductsController(ProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            _repository = repository;
        }

        public IHttpActionResult Get()
        {
            var service = new ProductService(_repository);
            var products = service.GetFeaturedProducts().ToViewModel();            

            return Ok(products);
        }
    }
}
