using ProductWebApi.Entities;

namespace ProductWebApi.Services
{
    public interface ProductInterface
    {
      Product Insert(Product product);
        Product Update(Product product);
        Product Delete(int ID);
        List<Product> GetAll();
    }
}
