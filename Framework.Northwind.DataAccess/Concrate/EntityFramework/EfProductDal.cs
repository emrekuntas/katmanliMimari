using System.Collections.Generic;
using Framework.Core.DataAccess.EntityFramework;
using Framework.Northwind.DataAccess.Abstract;
using Framework.Northwind.Entitys.Complex;
using Framework.Northwind.Entitys.Concrete;
using System.Linq;

namespace Framework.Northwind.DataAccess.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 CategoryName = c.CategoryName,
                                 ProductId = p.ProductID,
                                 productName = p.ProductName

                             };
                return result.ToList();
            }
        }
    }
}
