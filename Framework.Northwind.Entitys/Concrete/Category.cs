using Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.Entitys.Concrete
{
    public class Category: IEntities
    {
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }

    }
}
