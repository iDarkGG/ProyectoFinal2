using Dependencias.Data;
using Dependencias.Model;

namespace API.Repositorio
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly MainContext context;
        public ProductRepository(MainContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(Product obj) => context.Update(obj);
        
    }
}
