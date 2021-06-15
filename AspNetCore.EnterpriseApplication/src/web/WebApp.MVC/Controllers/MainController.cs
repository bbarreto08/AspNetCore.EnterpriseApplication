using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApp.MVC.Models;

namespace WebApp.MVC.Controllers
{
    public class MainController : Controller
    {
        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if(resposta != null && resposta.Errors.Mensagens.Any())
            {
                foreach (var item in resposta.Errors.Mensagens)
                {
                    ModelState.AddModelError(string.Empty, item);
                }

                return true;
            }

            return false;
        }
    }
}
