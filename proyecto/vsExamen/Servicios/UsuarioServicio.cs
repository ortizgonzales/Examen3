
using vsExamen.Data;
using vsExamen.Interfaces;
using Datos.Interfaces;
using Datos.repositorio; 
using modelos;

namespace vsExamen.Servicios
{
    public class UsuarioServicio : IUsuarioServicio

    {
        private readonly MySQLConfiguration _configuration;
        private IUsuarioRepositorio usuarioRepositorio;
        public UsuarioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;

            usuarioRepositorio = new UsuarioRepositorio(configuration.cadenaConexion);

        }




        public Task<bool> Actualizar(Interfaces.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Interfaces.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Interfaces.Usuario>> GetLista()
        {
            throw new NotImplementedException();
        }

        public async Task<Interfaces.Usuario> GetPorCodigo(string codigo)
        {
            return await usuarioRepositorio.GetLista(); 

        }

        public Task<bool> Nuevo(Interfaces.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidaUsuario(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
