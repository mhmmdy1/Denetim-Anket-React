using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.api.Extensions;
using Web.api.Models.Register;

namespace Web.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class LoginController : ControllerBase
    {
        private readonly IAccountService _accountService;
       
       
        public LoginController(IAccountService accountService)
        {
            this._accountService = accountService;

        }
        [HttpPost]
        public ActionResult CheckCredentials(LoginFormModel posted)
        {

            var response = new AxiousResponse();
            var account = new Account();
            var loginFormModel = new LoginFormModel();
            if (account.Email == loginFormModel.Email && account.Password == loginFormModel.Password)
            {
                FormAuthHelper.DoAuth(account, false);
                return JsonResult(response);
            }
            else
            {
                response.AddError("Geçersiz email veya şifre");
                response.Data = posted.ReturnUrl;

                return Json(response);
            }


        }
    }
}
