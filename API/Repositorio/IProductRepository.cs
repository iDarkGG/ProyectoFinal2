using Dependencias.Model;

namespace API.Repositorio
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
