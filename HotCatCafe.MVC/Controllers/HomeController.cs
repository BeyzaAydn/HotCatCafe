using HotCatCafe.BLL.ViewModels.AppUserViewModels;
using HotCatCafe.CMN.EmailHelpers;
using HotCatCafe.Model.Entities;
using HotCatCafe.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace HotCatCafe.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
           

            if (ModelState.IsValid)
            {

                AppUser user = new AppUser
                {
                    Email = registerViewModel.Email,
                    UserName=registerViewModel.Username
                    
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.ConfirmPassword);

                if (result.Succeeded)
                {
                    var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var encodeToken = HttpUtility.UrlEncode(emailToken);


                    string confirmationLink = Url.Action("Activation", "Home", new { id = user.Id, token = encodeToken }, Request.Scheme);

                    string body = $"Merhaba {registerViewModel.Username} kayıt olduğunuz için teşekkürler. Hesabını aktif hale getirebilmek için ilgili linki tıklayın. {confirmationLink}";


                    EmailSender.SendEmail(registerViewModel.Email, "Aktivasyon Maili", body);

                    TempData["Success"] = $"belirlemiş olduğunuz {registerViewModel.Email} adresine aktivasyon maili gönderildi. Lütfen ilgili linki tıklayarak üyeliğinizi aktif hale getirin.";

                }
                else
                {
                    TempData["Error"] = $"Bir hata meydana geldi";
                }





                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = $"Bir hata meydana geldi";
            }

            return View(registerViewModel);


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> Activation(string id, string token)
        {
            //kullanıcı konfirmasyon işlemi
            if (id != null && token != null)
            {
                var existsUser = await _userManager.FindByIdAsync(id);

                if (existsUser != null)
                {

                    var decodeToken = HttpUtility.UrlDecode(token);

                    var result = await _userManager.ConfirmEmailAsync(existsUser, decodeToken);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "hesabınız aktif hale getirildi.";
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }
    }







}








