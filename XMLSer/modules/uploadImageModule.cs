using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace XMLSer.modules
{
    public static class uploadImageModule
    {
        public static string Upload2imgbb(string x)
        {
            byte[] imageArray = File.ReadAllBytes(x);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            using (WebClient client = new WebClient())
            {
                //задаем параметры для коллекции
                NameValueCollection param = new NameValueCollection();
                param.Add("key", "50d7cec1c380ecf610b6475acb9a148f");
                //удалится через 3 дня
                param.Add("expiration", "259200");
                param.Add("image", base64ImageRepresentation);
                //делаем запрос методом POST и получем массив байтов
                var response = client.UploadValues("https://api.imgbb.com/1/upload", "POST", param);
                //декодируем
                var jsonResponse = Encoding.Default.GetString(response);
                //десериализуем
                JsonDeser UploadedImageData = JsonConvert.DeserializeObject<JsonDeser>(jsonResponse);
                string Answer = "url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022';
                Clipboard.SetData(DataFormats.Text, (Object)UploadedImageData.data.image.url);
                return Answer;
                //images.Add("url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022');
            }
        }
    }
}
