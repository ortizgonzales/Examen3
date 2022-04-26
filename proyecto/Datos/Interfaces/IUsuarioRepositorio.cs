﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelos;


namespace Datos.Interfaces;

public interface IUsuarioRepositorio
{

    Task<bool> Nuevo(Usuario usuario);
    Task<bool> Actualizar(Usuario usuario);
    Task<bool> Eliminar(Usuario usuario);
    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
    Task<bool> ValidaUsuario(Login login);


}
