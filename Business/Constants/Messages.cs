using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda lütfen daha sonra tekrar deneyiniz";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string UnitPriceInvalid = "Ürün Fiyatı geçersiz.";
        public static string ProductCountOfCategoryError = "Stokta aynı üründen en fazla 10 tane olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkisiz giriş";
        public static string UserRegistered = "Üye olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı adı var";
        public static string AccessTokenCreated;
    }
}
