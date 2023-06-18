using Dependencias.Model;

namespace API.Repositorio
{
    public interface IUserRepository : IRepository<User>
    {
        void Update(User obj);
    }
}
