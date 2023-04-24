using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductsListed="Sistem Bakımda";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Bulunabilir";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductNameAlreadyExists="Bu İsimde Zaten Başka Bir Ürün Var ";
        public static string CategoryLimitExceded="Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor";
        public static string AuthorizationDenied=" Yetkiniz Yok";
        public static string UserRegistered="Kayıt Olundu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Parola Hatası";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token Oluşturuldu";
        public static string ProductUpdated = "Ürün Güncellendi";
       
    }
}
