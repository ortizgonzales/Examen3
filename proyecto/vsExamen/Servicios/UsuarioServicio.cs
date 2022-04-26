
using vsExamen.Data;
using vsExamen.Interfaces;
using Datos.Interfaces;
using Datos.repositorio; 
using modelos;

namespace vsExamen.Servicios
{
public class UsuarioServicio : IUsuarioServicio
    {
        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetLista()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidaUsuario(Login login)
        {
            throw new NotImplementedException();
        }
    }




















    //suarioRepositorio = new UsuarioRepositorio( configuration.CadenaConexion);

}

        

       

       

        
    

