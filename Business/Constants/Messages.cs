using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersizdir";
        public static string MaintenanceTime ="Sisteme bakım yapılıyor";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError ="Ürün kategori sınırı aşıldı" ;
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün kayıtlı.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı yeni ürün eklenemiyor";
        public static string AuthorizationDenied=" Bu işlemi yapmaya yetkiniz yok";
        public static string UserRegistered="Kullanıcı kayıt edildi";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    } 
}
