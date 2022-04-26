using vsExamen.Data;
using Datos.Interfaces;
using Datos.repositorio;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using modelos;
using System.Security.Claims;

namespace Blazor.Controllers;

public class LoginController : Controller
{
    private readonly MySQLConfiguration _configuration;
    private IUsuarioRepositorio _usuarioRepositorio;

    public LoginController(MySQLConfiguration configuration)
    {
        _configuration = configuration;
        _usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }

    
   

            
        

  

}