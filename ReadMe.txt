HotCat Cafe Projesi


*Elimizde hali haz?rda bir veri taban? bulunmad??? i�in Code First y�ntemi ile tasarlanm??t?r.
*Projede Ntier Katmanl? Mimari kullan?lm??t?r.
NTier mimarisinin kullan?lma nedenleri:
1)NTier mimarisi, yaz?l?m sistemlerini daha y�netilebilir, �l�eklenebilir ve esnek hale getirmek amac?yla kullan?lan bir yaz?l?m mimarisidir. 

--Mod�lerlik ve Bak?m Kolayl???: NTier mimarisi, uygulaman?n farkl? katmanlar?n? (�rne?in, veri eri?im katman?, i? mant??? katman? ve sunum katman?) ayr? ayr? mod�ller halinde d�zenler. Bu, her bir katman?n ba??ms?z olarak geli?tirilmesini ve bak?m?n?n yap?lmas?n? kolayla?t?r?r.

--�l�eklenebilirlik: NTier mimarisi, sistemin belirli katmanlar?n?n gerekti?inde ayr? ayr? �l�eklenebilmesini sa?lar. �rne?in, veri taban? katman? veya i? mant??? katman?, artan talepler do?rultusunda ba??ms?z olarak �l�eklendirilebilir.

--G�venlik: Farkl? katmanlar aras?nda belirli g�venlik politikalar? uygulamak daha kolayd?r. �rne?in, veri eri?im katman?na sadece belirli yetkili bile?enler eri?ebilir, bu da g�venli?i art?r?r.

--Tekrar Kullan?labilirlik: ?? mant??? katman? veya veri eri?im katman? gibi bile?enler, farkl? uygulamalarda tekrar kullan?labilir. Bu, kod tekrar?n? azalt?r ve geli?tirme s�recini h?zland?r?r.

--Ba??ms?z Geli?tirme ve Test: Farkl? ekipler, farkl? katmanlar �zerinde ba??ms?z olarak �al??abilir ve test edebilirler. Bu da geli?tirme s�recini h?zland?r?r ve i? birli?ini kolayla?t?r?r.

--Performans: Farkl? katmanlar?n da??t?k sistemlerde yer alabilmesi, y�k dengeleme ve performans optimizasyonlar? i�in f?rsatlar sunar. �rne?in, yo?un veri i?lemleri i�in veri taban? katman? optimize edilebilir.

--Esneklik: NTier mimarisi, de?i?ikliklerin belirli katmanlarla s?n?rl? kalmas?n? sa?lar. �rne?in, sunum katman?nda yap?lacak bir de?i?iklik, i? mant??? veya veri eri?im katmanlar?n? etkilemez.


*
Ntier mimarisi projede 5  katman ?eklinde tasarlanm??t?r.
	
	- Model: Model katman? dal katman?nda varl?klar? temsil eden Entity'leri bar?nd?ran katmand?r.Dal katman?ndan ayr?  olarak d�zenlenmesinin sebebi Solid prensiplerinden Single Responsibility Principle'a uygun omas? i�indir.
		- Base: Interface'den alm?? oldu?u �zellikleri b�nyesine dahil eder.
		- Entities: Veritaban?nda olmas?n? istedi?imiz tablolar? temsil eder.
			- AppUser
			- AppUserRole
			- Category
			- Product
			- Order
			- OrderDetails



		- Enums: tablolarda kullan?lacak sabitleri temsil eder.
		- Interfaces: B�t�n classlara �nc�l�k edek �zellikleri bar?nd?r?r.

	- DAL (Data Access Layer): Veritaban?na ula??m katman?n? temsil eder. Veritaban? ile ilgili nesnelerimiz, tasar?m desenleri, Entity gibi varl?klar bu katman i�erisinde kullan?lmal?d?r.
		- Context: Veritaban? nesnesini temsil eder.


	- BLL (Business Logic Layer): ?? mant??? katman? olarak kullan?lacakt?r. Kullan?c?n talep etti?i i?lemler ilk olarak bu katman taraf?ndan kar??lanacak. Repository ve Service bu katman i�erisinde olu?turulacak.
		--Repositories
			--Abstracts
				--BaseAbstracts
					-IRepository: Bu interface b�t�n i?lemlere �nc�l�k edecek metotlar?n kurallar?n? bar?nd?rmaktad?r. (CRUD) Interface d??ar?dan bir T al?r.
		--Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotlar?) somut hale d�n�?t�ren class.. D?a?r?dan bir T al?r

	Yukar?daki tan?mlamalarda bulunan T tipleri Ayr? bir servis olu?turulacak. Bu kurallar? b�nyesine al?r. Bu kurallara g�re spesifik eylemleri ger�ekle?tirir. �rne?in CategoryService'de ger�ekle?tirildi?i gibi. (Bknz. CategoryService)
			

	- UI (User Interface): Sunum katman?n? temsil eder. 
		- MVC projesi bu katman i�erisinde olu?turulacak. 
		- Console App
		- WebApi

    - Common (Ortak Katman): ?lerleyen etaplarda projenin daha esnek olabilmesi i�in her bir katmanda ortak olarak kullan?lacak i?lemler/yap?lar bu katmanda yer almaktad?rlar.
		--ImageHelper: ?e�risinde bulunan static metot vas?tas?yla d?a?r?dan iletilen dosyan?n bir g�rsel olup olmad???n? kontrol edilmesini ard?ndan bu g�rselin projeye dahil edilmesini ger�ekle?tirir.
