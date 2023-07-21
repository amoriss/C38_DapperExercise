using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C38DapperDemo;
internal interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    void CreateProduct(string name, double price, int categoryID);
    public Product GetProduct(int id);
    public void UpdateProduct(Product product);
    public void DeleteProduct(int id);
}
