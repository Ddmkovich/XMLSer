using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSer.Classes
{
    public class XMLSerDeser
    {
        public void SerializeAvito(Ads ad)
        {
            //Сериализирует все объекты из ListView в xml файл
            XmlSerializer xmlSerializer = new XmlSerializer(ad.GetType());
            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            using (FileStream fs = new FileStream("Avito.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, ad, xns);

            }

        }
        public void SerializeYoula(yml_catalog offers)
        {
            //Сериализирует все объекты из ListView в xml файл
            XmlSerializer xmlSerializer = new XmlSerializer(offers.GetType());
            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            using (FileStream fs = new FileStream("Youla.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, offers, xns);

            }

        }
        public Ads DeserializeAvito()
        {
            //Десериализирует компоненты из xml файла в ListView
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Ads));
            using (FileStream fs = new FileStream("Avito.xml", FileMode.OpenOrCreate))
            {
                return (Ads)xmlSerializer.Deserialize(fs);

            }
        }
        public yml_catalog DeserializeYoula()
        {
            //Десериализирует компоненты из xml файла в ListView
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(yml_catalog));
            using (FileStream fs = new FileStream("Youla.xml", FileMode.OpenOrCreate))
            {
                return (yml_catalog)xmlSerializer.Deserialize(fs);

            }
        }
    }
}
