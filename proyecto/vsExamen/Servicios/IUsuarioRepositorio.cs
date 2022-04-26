

using modelos;

namespace vsExamen.Servicios
{
    public interface IUsuarioRepositorio
    {
       
        Task<IEnumerable<Usuario>> GetLista();
        Task<Usuario> GetPorCodigo(string codigo);
        Task<bool> ValidaUsuario(Login login);
    }
}