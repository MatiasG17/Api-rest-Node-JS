
using System.Web.Mvc;

public class AccountController : Controller
{
    private UsuarioServicio usuarioService = new UsuarioServicio();

    
    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }

    
    [HttpPost]
    public ActionResult Login(string correo, string password)
    {
        var usuario = usuarioService.Login(correo, password);

        if (usuario != null)
        {
            Session["Usuario"] = usuario;
            
            return RedirectToAction("Index", "Dashboard");

        }
        else
        {
            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }
    }

    
    [HttpGet]
    public ActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public ActionResult Register(string nombres, string correo, string password)
    {
        bool registrado = usuarioService.Registrar(nombres, correo, password);

        if (registrado)
        {
            TempData["RegistroOk"] = "¡Usuario registrado correctamente! Ahora puedes iniciar sesión.";
            return RedirectToAction("Login", "Account");
        }
        else
        {
            ViewBag.Error = "Error al registrar el usuario. Tal vez el correo ya existe.";
            return View("Login");
        }
    }

    public ActionResult Logout()
    {
        Session.Clear(); 
        return RedirectToAction("Login", "Account");
    }

}
