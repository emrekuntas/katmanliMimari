using Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.Entitys.Concrete
{
    public class Product : IEntities
    {

        public int ProductID { get; set; }
        public string  ProductName { get; set; }
        public int CategoryId { get; set; }
        public string  QuantityPerUnit { get; set; }
    }
}
