using HotCatCafe.Model.Enums;
using System.Net.Sockets;

namespace HotCatCafe.Model.Interfaces
{
    //Bu interface tüm entitylere OOP Prensipi olan inheritance yöntemi ile bırakılacaktır.Aynı zamanda Generic Bir type parametresi alacaktır.Bu kodun daha esnek ve yeniden kullanılabilir olmasını sağlayacaktır.
    public interface IEntity<T>
    {
        public int ID { get; set; }
        public  T MasterId { get; set; }//Verinin UIdaki Idsi MasterID ile sağlacaktır. Böylelikle güvenlik açığı oluşturulmayacaktır.

        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public AddressFamily  CreatedIpAdress{ get; set; }

        public DateTime UpdatedDate { get; set; }
        public string? UpdatedComputerName { get;}
        public string? UpdatedIpAdress { get; set; }

       
        public DataStatus Status { get; set; }  //Verinin statüsünü enum yapısı içinde belirleyerek bu yapıyı property içinde kullandık.(eklendi,silindi,güncellendi enumları kullanıldı.)
        public Active Active { get; set; }

    }
}
