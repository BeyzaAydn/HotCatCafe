using HotCatCafe.Model.Enums;
using HotCatCafe.Model.Interfaces;
using System.Net.Sockets;

namespace HotCatCafe.Model.Base
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public BaseEntity() 
        {
            Status=DataStatus.Inserted;
            Status=DataStatus.IsActive;
            CreatedDate = DateTime.Now;
            CreatedComputerName=System.Environment.MachineName;
            CreatedIpAdress = System.Net.Sockets.AddressFamily.InterNetwork;//Bu bize System.Net.Sockets namespacei içinde bulunan AddressFamily enumı içinde tanımlanan InterNetwork değeri  kullanılarak bilgisayarın IPv4 adresini almamızı sağlayacaktır.
            MasterId=Guid.NewGuid();
        }

        public int ID { get ; set ; }
        public Guid MasterId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string CreatedComputerName { get ; set ; }
        public AddressFamily CreatedIpAdress { get ; set ; }
        public DateTime UpdatedDate { get ; set ; }

        public string? UpdatedComputerName { get; set; }
 

        public string? UpdatedIpAdress { get ; set ; }
        public DataStatus Status { get ; set ; }
    }
}
