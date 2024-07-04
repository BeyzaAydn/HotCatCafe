using HotCatCafe.Model.Enums;
using Microsoft.AspNetCore.Identity;

namespace HotCatCafe.Model.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public DateTime? BirthDate { get; set; }
        public string? Address {  get; set; }
        public Gender Gender { get; set; }
    }
}
