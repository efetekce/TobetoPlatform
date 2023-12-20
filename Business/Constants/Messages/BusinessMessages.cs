using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public class BusinessMessages
    {
        public static string FileFormatControl = "Sadece image/jpeg, image/png, application/pdf yükleyebilirsiniz";
        public static string NotNullableFileName = "Dosya adı boş olamaz";
        public static string TooLongFileName = "Dosya adı çok uzun";
        public static string NotValidCharacters = "Dosya adında [<>:\"/\\\\|?*] karakterler bulunamaz";
        public static string AccountControl = "Geçerli bir kullanıcı için dosya yükleyiniz";
    }
}
