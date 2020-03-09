using Framework.Northwind.Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.Concrate.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {

        public CategoryMap()
        {
            ToTable(@"Category", @"dbo");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
     
        }
    {
    }
}
