using reventTest.Model;

namespace reventTest.Services
{
    public interface IProductService
    {
        List<Products> GetProducts();
        string AddProduct(Products products);
        string RemoveProduct(string Id);
    }

    public class ProductService : IProductService
    {
        private static List<Products> _products = new List<Products>
        {
            new Products{Id="1",Name="Dummy1"},
            new Products{Id="2",Name="Dummy2"},
            new Products{Id="3",Name="Dummy3"},
        };


        public ProductService()
        {

        }
        public List<Products> GetProducts()
        {
            return _products;
        }
        public string AddProduct(Products products)
        {
            var isExist = _products.Contains(products);
            if (isExist)
            {
                return "Product Previously Exist";
            }
            _products.Add(products);
            return "Product Added Successfully";
        }
        public string RemoveProduct(string Id)
        {
            var isExist = _products.RemoveAll(x=>x.Id == Id);
            if (isExist> 0)
            {
                return $"{isExist} Product(s) Deleted";
            }
            return "Product with specified Id does not exist";
        }
    }
}