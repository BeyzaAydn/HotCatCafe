using HotCatCafe.Model.Base;

namespace HotCatCafe.Model.Entities
{
   public class Product:BaseEntity
    {
        public  string  ProductName  { get; set; }

        public decimal UnitPrice {  get; set; }

        public  int UnitInStock { get; set; }

        public int Quantity {  get; set; }  

        public decimal Discount { get; set; }

        //Mapping
        public int CategoryId {  get; set; }
        public virtual  Category Category { get; set; }//Lazy Loading için virtual anahtar kelimesi kullanılmıştır.Lazy Loading kullanılmasının nedeni Product nesnesinin yüklenmesi  esnasında Category nesnesinin yüklenmesinin engellenmesidir.Böylelikle performans açısından etkili bir proje tasarlanmış olacaktır.Aynı zamanda virtual ifadesi, polymorphism (çok biçimlilik) ve inheritance (kalıtım) kavramlarının uygulanmasına olanak tanır.
    }
}
