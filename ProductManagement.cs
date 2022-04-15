using System;
using System.Collections.Generic;
using System.Linq;

namespace Day35_ProductReviewManagement
{
    public class ProductManagement
    {

        public void DisplayAllProducts(List<ProductReview> ProductList)
        {
            Console.WriteLine("\n - - -  Displaying All products - - - ");
            foreach (ProductReview p in ProductList)
            {
                Console.WriteLine("Product Id : {0}\tUser Id : {1}\tRating : {2}\tReview : {3}\tIsLike : {4}", p.ProductId, p.UserId, p.Rating, p.Review, p.isLike);
            }
        }
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
        public void RetriveRecords(List<ProductReview> ProductList)
        {
            List<ProductReview> result;
            result = (from prod in ProductList where (prod.Rating > 3) && (prod.ProductId == 10 || prod.ProductId == 40 || prod.ProductId == 90) select prod).ToList();

            Console.WriteLine(" displaying Top 3 products");

            foreach (ProductReview p in result)
            {
                Console.WriteLine("Product Id : {0}\tUser Id : {1}\tRating : {2}\tReview : {3}\tIsLike : {4}", p.ProductId, p.UserId, p.Rating, p.Review, p.isLike);
            }
        }
        public void CountOfUser(List<ProductReview> ProductList)
        {
            Console.WriteLine("\n - - -  Retrieve count of review present for each productID - - - ");
            var reviewResult = ProductList
                .GroupBy(p => p.ProductId)
                .Select(pi => new
                { ProductId = pi.Key, count = pi.Count() });
            foreach (var p in reviewResult)
            {
                Console.WriteLine(" Product Id : {0} \t ReviewCount : {1}", p.ProductId, p.count);
            }
        }
        
        public void SkipTop5Records(List<ProductReview> ProductList)
        {
            var result = (from pr
                          in ProductList
                          select pr).Skip(5);

            Console.WriteLine("\n - - -  Displaying top 5 skipped records - - - ");
            Console.WriteLine(" ProductId\tUserId Rating\tReview \t IsLike ");

            foreach (ProductReview p in result)
            {
                Console.WriteLine(" {0}\t\t{1}\t{2}\t{3}\t  {4}", p.ProductId, p.UserId, p.Rating, p.Review, p.isLike);
            }
        }
        public void ShowProductIDAndReview(List<ProductReview> ProductList)
        {
            List<ProductReview> result;
            result = (from prod in ProductList
                      orderby (prod.ProductId)
                      select prod).ToList();

            Console.WriteLine("\n - - -  Display productID , Reviews from all records  - - -");
            Console.WriteLine(" Product Id \t Review");

            foreach (ProductReview p in result)
            {
                Console.WriteLine(" {0}\t\t{1}", p.ProductId, p.Review);
            }
        }



    }
}
