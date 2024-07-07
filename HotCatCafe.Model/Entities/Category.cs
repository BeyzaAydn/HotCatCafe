using HotCatCafe.Model.Base;

namespace HotCatCafe.Model.Entities
{
    public  class Category:BaseEntity
    {
        public string CategoryName {  get; set; }
        public string Description { get; set; }
       
        //Mapping

        public virtual List<Product> Products { get; set; }//Lazy Loading için virtual anahtar kelimesi kullanılmıştır.Lazy Loading kullanılmasının nedeni Category nesnesinin yüklenmesi  esnasında Product nesnesinin yüklenmesinin engellenmesidir.Böylelikle performans açısından etkili bir proje tasarlanmış olacaktır.Aynı zamanda virtual ifadesi, polymorphism (çok biçimlilik) ve inheritance (kalıtım) kavramlarının uygulanmasına olanak tanır.


    }
}
