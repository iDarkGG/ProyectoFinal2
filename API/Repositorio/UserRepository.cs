using Dependencias.Data;
using Dependencias.Model;

namespace API.Repositorio
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        private readonly MainContext context;
        public UserRepository(MainContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(User obj)
        {
            context.Update(obj);
        }
    }
}
