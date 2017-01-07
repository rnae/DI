using System.Collections.Generic;
using System.Linq;
using BLL;
using Lesson2.Models;

namespace Lesson2.Mappers
{
    public static class ProductsMapper
    {

        public static List<ProductModel> ToViewModel(this IEnumerable<Product> products)
        {
            if (products == default(IEnumerable<Product>))
            {
                return default(List<ProductModel>);
            }

            var _products = new List<ProductModel>();
            products.ToList().ForEach(p => _products.Add(p.ToViewModel()));

            return _products;
        }
    }
}