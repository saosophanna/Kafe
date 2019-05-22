using System.Collections.Generic;
using System.Linq;

namespace Kafe.CoreSystem
{
    public static class CovertoToProducts
    {
        public static IEnumerable<Products> ToProduct(this List<ProductDesign> products)
        {
            return products.SelectMany(pd => new List<Products>
            {
                new Products()
                {
                    Code = pd.Code,
                    Name = pd.Name,
                    Type = pd.Type,
                    Quantity = pd.Quantity,
                    Price = pd.Price,
                    DisPercent = pd.DisPercent,
                    Description = pd.Description
                }
            });
        }
    }
}