using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string CarDeleted = "Araba Silindi";
        public static string CarDeleteInvalid = "Araba Silinemedi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarUpdateInvalid = "Araba Güncellenemedi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarsListInvalid = "Arabalar listelenemedi";


        public static string BrandAdded = "Marka eklendi";
        public static string BrandAddInvalid = "Marka eklenemedi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandDeleteInvalid = "Marka Silinemedi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandUpdateInvalid = "Marka Güncellenemedi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandListInvalid = "Markalar listelenemedi";


        public static string ColorAdded = "Renk eklendi";
        public static string ColorAddInvalid = "Renk eklenemedi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorDeleteInvalid = "Renk Silinemedi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorUpdateInvalid = "Renk Güncellenemedi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorListeInvalid = "Renkler listelenemedi";


        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserAddInvalid = "Kullanıcı eklenemedi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserUpdateInvalid = "Kullanıcı güncellenemedi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserDeleteInvalid = "Kullanıcı silinemedi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UsersListInvalid = "Kullanıcılar listelenemedi";


        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerAddInvalid = "Müşteri eklenemedi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerUpdateInvalid = "Müşteri güncellenemedi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerDeleteInvalid = "Müşteri silinemedi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomersListInvalid = "Müşteriler listelenemedi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalAddInvalid = "Araç kiralanmaya uygun değil";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalUpdateInvalid = "Kiralama güncellenemedi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalDeleteInvalid = "Kiralama silinemedi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalsListInvalid = "Kiralamalar listelenemedi";

        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarImageDefaultCount = "Arabaya eklenecek maksimum fotograf sayısı";
        public static string CarImageAdded = "Araba fotosu eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok ";
        public static string UserRegistered = "Kayıt oldu";
        public static string AccessTokenCreated = "Token oluşturuldu";
        internal static JwtUser UserNotFound;
        internal static JwtUser PassswordError;
        internal static string SuccesfullyLogin;
        internal static string UserAlreadyExist;
    }
}
