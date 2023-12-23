using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public class BusinessMessages
    {
        public static string SameAccountSocialMediaLinkError = "Eklemeye çalıştığınız link mevcuttur!";
        public static string SameUniversityNameError = "Eklemeye çalıştığınız üniversite mevcuttur!";
        public static string SameProgramNameError = "Eklemeye çalıştığınız bölüm mevcuttur!";
        public static string OrganizationRuleError = "Hata!";
        public static string SameSocialMediaNameError = "Eklemeye çalıştığınız sosyal medya platformu mevcuttur!";
        public static string ExperienceRuleError = "Aynı!";
        public static string SameCountryNameError = "Eklemeye çalıştığınız ülke ismi mevcut!";
        public static string SameCityNameError = "Aynı ülkede aynı şehirler olamaz!";
        public static string ExperienceCannotBeEmpty = "Bu alan veya alanlar boş bırakılamaz!";
        public static string AccountApplicationCannotBeEmpty = "Bu alan veya alanlar boş bırakılamaz!";
        public static string AccountEducationCannotBeEmpty = "Bu alan veya alanlar boş bırakılamaz!";
        public static string FileFormatControl = "Sadece image/jpeg, image/png, application/pdf yükleyebilirsiniz";
        public static string NotNullableFileName = "Dosya adı boş olamaz";
        public static string TooLongFileName = "Dosya adı çok uzun";
        public static string NotValidCharactersInFileName = "Dosya adında [<>:\"/\\\\|?*] karakterler bulunamaz";
        public static string RequiredAccountForCertificate = "Geçerli bir kullanıcı için dosya yükleyiniz";
        public static string RequiredAccountForCourse = "Geçerli bir kullanıcı için kayıt yapınız";
        public static string RequiredCourse = "Geçerli bir eğitim için kayıt yapınız";
        public static string NotNullableContentTypeName = "İçerik tipi boş olamaz";
        public static string NotNullableCategoryName = "Kategori boş olamaz";
        public static string NotNullableLessonStatusName = "Statü boş olamaz";
        public static string NotNullableContentName = "İçerik adı boş olamaz";
        public static string RequiredContentType = "Geçerli bir içerik tipi için kayıt yapınız";
        public static string RequiredContent = "Geçerli bir içerik adı için kayıt yapınız";
        public static string NotNullableLessonName = "Ders adı boş olamaz";
        public static string RequiredLesson = "Geçerli bir ders için kayıt yapınız";
        public static string RequiredLessonStatus = "Geçerli bir ders statüsü bulunamadı";
        public static string NotNullableCourseName = "Kurs adı boş olamaz";
        public static string NotNullableImagePath = "Fotoğraf yüklenmelidir";
        public static string RequiredCourseCategory = "Geçerli bir kategori için kayıt yapınız";
        public static string RequiredOrganization = "Geçerli bir kurum için kayıt yapınız";
        public static string NotNullableLanguage = "Dil adı boş olamaz"; //burayı güncelle; lang id kullanılmalı 
        public static string NotNullableSubType = "Alt tip boş olamaz";
        public static string NotNullableOrganizationName = "Kurum boş olamaz";
        public static string NotNullableContactNumber = "İletişim numarası boş olamaz";
        public static string RequiredAddress = "Geçerli bir adres için kayıt yapınız";
    }
}
