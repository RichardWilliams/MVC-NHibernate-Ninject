using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class ProductsViewModel : List<ProductViewModel>
    {
        public ProductsViewModel(IEnumerable<ProductViewModel> products)
        {
            AddRange(products);
        }
    }
}