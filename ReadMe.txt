HotCat Cafe Projesi


*Elimizde hali haz?rda bir veri taban? bulunmad??? için Code First yöntemi ile tasarlanm??t?r.
*Projede Ntier Katmanl? Mimari kullan?lm??t?r.
NTier mimarisinin kullan?lma nedenleri:
1)NTier mimarisi, yaz?l?m sistemlerini daha yönetilebilir, ölçeklenebilir ve esnek hale getirmek amac?yla kullan?lan bir yaz?l?m mimarisidir. 

--Modülerlik ve Bak?m Kolayl???: NTier mimarisi, uygulaman?n farkl? katmanlar?n? (örne?in, veri eri?im katman?, i? mant??? katman? ve sunum katman?) ayr? ayr? modüller halinde düzenler. Bu, her bir katman?n ba??ms?z olarak geli?tirilmesini ve bak?m?n?n yap?lmas?n? kolayla?t?r?r.

--Ölçeklenebilirlik: NTier mimarisi, sistemin belirli katmanlar?n?n gerekti?inde ayr? ayr? ölçeklenebilmesini sa?lar. Örne?in, veri taban? katman? veya i? mant??? katman?, artan talepler do?rultusunda ba??ms?z olarak ölçeklendirilebilir.

--Güvenlik: Farkl? katmanlar aras?nda belirli güvenlik politikalar? uygulamak daha kolayd?r. Örne?in, veri eri?im katman?na sadece belirli yetkili bile?enler eri?ebilir, bu da güvenli?i art?r?r.

--Tekrar Kullan?labilirlik: ?? mant??? katman? veya veri eri?im katman? gibi bile?enler, farkl? uygulamalarda tekrar kullan?labilir. Bu, kod tekrar?n? azalt?r ve geli?tirme sürecini h?zland?r?r.

--Ba??ms?z Geli?tirme ve Test: Farkl? ekipler, farkl? katmanlar üzerinde ba??ms?z olarak çal??abilir ve test edebilirler. Bu da geli?tirme sürecini h?zland?r?r ve i? birli?ini kolayla?t?r?r.

--Performans: Farkl? katmanlar?n da??t?k sistemlerde yer alabilmesi, yük dengeleme ve performans optimizasyonlar? için f?rsatlar sunar. Örne?in, yo?un veri i?lemleri için veri taban? katman? optimize edilebilir.

--Esneklik: NTier mimarisi, de?i?ikliklerin belirli katmanlarla s?n?rl? kalmas?n? sa?lar. Örne?in, sunum katman?nda yap?lacak bir de?i?iklik, i? mant??? veya veri eri?im katmanlar?n? etkilemez.


*
Ntier mimarisi projede 5  katman ?eklinde tasarlanm??t?r.
	
	- Model: Model katman? dal katman?nda varl?klar? temsil eden Entity'leri bar?nd?ran katmand?r.Dal katman?ndan ayr?  olarak düzenlenmesinin sebebi Solid prensiplerinden Single Responsibility Principle'a uygun omas? içindir.
		- Base: Interface'den alm?? oldu?u özellikleri bünyesine dahil eder.
		- Entities: Veritaban?nda olmas?n? istedi?imiz tablolar? temsil eder.
			- AppUser
			- AppUserRole
			- Category
			- Product
			- Order
			- OrderDetails



		- Enums: tablolarda kullan?lacak sabitleri temsil eder.
		- Interfaces: Bütün classlara öncülük edek özellikleri bar?nd?r?r.

	- DAL (Data Access Layer): Veritaban?na ula??m katman?n? temsil eder. Veritaban? ile ilgili nesnelerimiz, tasar?m desenleri, Entity gibi varl?klar bu katman içerisinde kullan?lmal?d?r.
		- Context: Veritaban? nesnesini temsil eder.


	- BLL (Business Logic Layer): ?? mant??? katman? olarak kullan?lacakt?r. Kullan?c?n talep etti?i i?lemler ilk olarak bu katman taraf?ndan kar??lanacak. Repository ve Service bu katman içerisinde olu?turulacak.
		--Repositories
			--Abstracts
				--BaseAbstracts
					-IRepository: Bu interface bütün i?lemlere öncülük edecek metotlar?n kurallar?n? bar?nd?rmaktad?r. (CRUD) Interface d??ar?dan bir T al?r.
		--Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotlar?) somut hale dönü?türen class.. D?a?r?dan bir T al?r

	Yukar?daki tan?mlamalarda bulunan T tipleri Ayr? bir servis olu?turulacak. Bu kurallar? bünyesine al?r. Bu kurallara göre spesifik eylemleri gerçekle?tirir. Örne?in CategoryService'de gerçekle?tirildi?i gibi. (Bknz. CategoryService)
			

	- UI (User Interface): Sunum katman?n? temsil eder. 
		- MVC projesi bu katman içerisinde olu?turulacak. 
		- Console App
		- WebApi

    - Common (Ortak Katman): ?lerleyen etaplarda projenin daha esnek olabilmesi için her bir katmanda ortak olarak kullan?lacak i?lemler/yap?lar bu katmanda yer almaktad?rlar.
		--ImageHelper: ?eçrisinde bulunan static metot vas?tas?yla d?a?r?dan iletilen dosyan?n bir görsel olup olmad???n? kontrol edilmesini ard?ndan bu görselin projeye dahil edilmesini gerçekle?tirir.
