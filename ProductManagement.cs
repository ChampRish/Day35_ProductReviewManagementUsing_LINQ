using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_ProductReviewManagement
{
    public class ProductManagement
    {
        

        public void Top3Products(List<ProductReview> ProductList)
        {
            var result = (from pr
                          in ProductList
                          orderby pr.Rating descending
                          select pr).Take(3);

            Console.WriteLine(" displaying Top 3 products");

            foreach (ProductReview p in ProductList)
            {
                Console.WriteLine("Product Id : {0}\tUser Id : {1}\tRating : {2}\tReview : {3}\tIsLike : {4}", p.ProductId, p.UserId, p.Rating, p.Review, p.isLike);
            }
        }

    }
}
