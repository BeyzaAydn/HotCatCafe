using System.ComponentModel.DataAnnotations;

namespace HotCatCafe.BLL.ViewModels.AppUserViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        [Display(Name = "Kullanıcı adı")]

        public string Username { get; set; }

        
        [Required(ErrorMessage = "Email boş geçilemez")]
        [EmailAddress(ErrorMessage = "Değer email formatında olmalı")]
        
        private string _emailAddress;
        public string Email
        {

            get { return _emailAddress; }

            set
            {
                var usernameArray = value.Split('@');
                Username = usernameArray[0];
                _emailAddress = value;
            }



        }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        
        [Required(ErrorMessage = "Şifre (Tekrar) boş geçilemez")]
        [Display(Name = "Şifre (Tekrar)")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

    }
}

