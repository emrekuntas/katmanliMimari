using Framework.Core.DataAccess.EntityFramework;
using Framework.Northwind.DataAccess.Abstract;
using Framework.Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.Concrate.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
