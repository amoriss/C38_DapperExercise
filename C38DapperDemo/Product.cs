using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C38DapperDemo;
internal class Product //class represents the table
{
    //each column from the products table will be a property
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int CategoryID { get; set; }
    public bool OnSale { get; set; }
    public int StockLevel { get; set; }
}
