using Dapper;
using Datos.Interfaces;
using modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.repositorio;

public class UsuarioRepositorio : IUsuarioRepositorio
{
    private string CadenaConexion;

    public UsuarioRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
    }

    public async Task<bool> Actualizar(usuario usuario)
    {
        int resultado;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "UPDATE usuario SET.cod = @.cod, use= @use, rol = @rol,contra = @contra WHERE cod = @cod ;";
            resultado = await conexion.ExecuteAsync(sql, new
            {
                usuario.cod,
                usuario.user,
                usuario.rol,
                usuario.contra,
               
            });
            return resultado > 0;
        }
        catch (Exception ex)
        {
            return false;
        }

    }

    public static Task<global::vsExamen.Interfaces.Usuario> getLista()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Eliminar(usuario usuario)
    {
        int resultado;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "DELETE FROM usuario WHERE cod = @cod;";
            resultado = await conexion.ExecuteAsync(sql, new { usuario.cod });
            return resultado > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<IEnumerable<usuario>> GetLista()
    {
        IEnumerable<usuario> lista = new List<usuario>();

        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM usuario;";
            lista = await conexion.QueryAsync<usuario>(sql);
        }
        catch (Exception ex)
        {
        }
        return lista;
    }

    public async Task<usuario> GetPorCodigo(string cod)
    {
        usuario user = new usuario();
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM usuario WHERE Codigo = @Codigo;";
            user = await conexion.QueryFirstAsync<Usuario>(sql, new { codigo });
        }
        catch (Exception)
        {
        }
        return user;
    }

    public async Task<bool> Nuevo(Usuario usuario)
    {
        int resultado;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "INSERT INTO usuario (Codigo, Nombre, Rol, Clave, EstaActivo) VALUES (@Codigo, @Nombre, @Rol, @Clave, @EstaActivo)";
            resultado = await conexion.ExecuteAsync(sql, usuario);
            return resultado > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<bool> ValidaUsuario(Login login)
    {
        bool valido = false;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT 1 FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";
            valido = await conexion.ExecuteScalarAsync<bool>(sql, new { login.Codigo, login.Clave });
        }
        catch (Exception ex)
        {
        }
        return valido;
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Usuario>> IUsuarioRepositorio.GetLista()
    {
        throw new NotImplementedException();
    }

    Task<Usuario> IUsuarioRepositorio.GetPorCodigo(string codigo)
    {
        throw new NotImplementedException();
    }
}
