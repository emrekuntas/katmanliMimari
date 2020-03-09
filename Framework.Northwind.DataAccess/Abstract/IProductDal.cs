using Framework.Core.DataAccess;
using Framework.Northwind.Entitys.Complex;
using Framework.Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();

    }
}
