using System;
using Framework.Northwind.DataAccess.Concrate.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework.Northwind.DataAccess.Test.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_add_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

             var result=productDal.GetList();

            Assert.AreEqual(77, result.Count);


        }
    }
}
