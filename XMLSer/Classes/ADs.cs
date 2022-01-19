using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLSer
{
    [Serializable]
    //Класс для Авито xml файла
    public class Ads
    {
        //Атрибуты для авито
        [XmlAttribute("formatVersion")]
        public string formatVersion = "3";
        [XmlAttribute("target")]
        public string target = "Avito.ru";
        public List<Ad> ADList { get; set; } = new List<Ad>();
    }
    [Serializable]
    public class Ad
    {
        //Название полей соответсвуют тегам в xml файле, где это не указано напрямую
        public string Id { get; set; }
        public string Title { get; set; }
        public string DateBegin { get; set; }
        public string DateEnd { get; set; }
        public string AdStatus { get; set; }
        public string Category { get; set; }
        public string GoodsType { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string ContactMethod { get; set; }
        public string ContactManager { get; set; }
        public string ContactPhone { get; set; }
        public string Price { get; set; }
        public string Address { get; set; }
        [XmlArrayItem("Image")]
        public List<string> Images { get; set; } = new List<string>();
        public string VideoUrl { get; set; }

        //Необходим для некоторых типов товаров
        public string AdType { get; set; }
        //Вторичные для телефона
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string MemorySize { get; set; }
        public string RamSize { get; set; }

        //Пустой конструктор необходим для сериализации
        public Ad() { }
        //Не пустой конструктор для заполнения данных
        public Ad(string Id, string Title, string DateBegin, string DateEnd, string AdStatus,
            string Category, string GoodsType, string Condition, string Description,
            string ContactMethod,string ContactManager, string ContactPhone, string Price, string Address, List<string> images, string VideoUrl,
            string Vendor, string Model, string Color, string MemorySize, string RamSize, string AdType)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.DateBegin = DateBegin;
            this.DateEnd = DateEnd;
            this.AdStatus = AdStatus;
            this.Category = Category;
            this.GoodsType = GoodsType;
            this.Condition = Condition;
            this.ContactMethod = ContactMethod;
            this.ContactManager = ContactManager;
            this.ContactPhone = ContactPhone;
            this.Price = Price;
            this.Address = Address;
            this.Images.AddRange(images);
            this.VideoUrl = VideoUrl;
            this.AdType = AdType;
            this.Vendor = Vendor;
            this.Model = Model;
            this.Color = Color;
            this.RamSize = RamSize;
            this.MemorySize = MemorySize;
        }
    }
    [Serializable]
    public class yml_catalog
    {
        [XmlAttribute("xmlns")]
        public string xmlns = "http://webmaster.yandex.ru/schemas/feed/realty/2010-06";

        public List<offer> offerList { get; set; } = new List<offer>();
    }
    [Serializable]
    public class offer
    {
        //Название полей соответсвуют тегам в xml файле, где это не указано напрямую
        [XmlAttribute("id")]
        public string id = DateTime.Now.ToString();
        public string name { get; set; }
        public string youlaCategoryId { get; set; }
        public string youlaSubcategoryId { get; set; }
        public string description { get; set; }
        public string managerName { get; set; }
        public string phone { get; set; }
        public string price { get; set; }
        public string address { get; set; }
        [XmlArrayItem("picture")]
        public List<string> Images { get; set; } = new List<string>();
        //Пустой конструктор необходим для сериализации
        public offer() { }
        //Не пустой конструктор для заполнения данных
        public offer(string name, string youlaCategoryId, string youlaSubcategoryId, string description,
             string managerName, string phone, string price,
            string address, List<string> images)
        {
            this.name = name;
            this.youlaCategoryId = youlaCategoryId;
            this.youlaSubcategoryId = youlaSubcategoryId;
            this.description = description;
            this.managerName = managerName;
            this.phone = phone;
            this.price = price;
            this.address = address;
            this.Images.AddRange(images);
        }
    }
}
