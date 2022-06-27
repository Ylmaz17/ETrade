using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string ProductNameAlreadyExists = "Bu isimde bir üeün kayıtlı.";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldı yeni ürün eklenemiyor";
    }
}
