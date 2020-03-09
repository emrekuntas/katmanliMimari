using Framework.Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.Concrate.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {

        public ProductMap()
        {
            ToTable(@"Product", @"dbo");
            HasKey(x => x.ProductID);

            Property(x => x.ProductID).HasColumnName("ProductID");
            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
        }
    }
}
