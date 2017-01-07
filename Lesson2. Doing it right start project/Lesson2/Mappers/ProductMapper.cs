using BLL;
using Lesson2.Models;

namespace Lesson2.Mappers
{
    public static class ProductMapper
    {

        public static ProductModel ToViewModel(this Product product)
        {
            if (product == default(Product))
            {
                return default(ProductModel);
            }

            return new ProductModel
            {
                Title = product.Title,
                Description = product.Description
            };
        }
    }
}