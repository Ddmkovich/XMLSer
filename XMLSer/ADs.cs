﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSer
{

    [Serializable] 
    public class ADs
    {
        //Атрибуты для авито
        [XmlAttribute("formatVersion")]
        public string formatVersion = "3";
        [XmlAttribute("target")]
        public string target = "Avito.ru";

        public List<ADData> AdsList { get; set; } = new List<ADData>();
    }


    [Serializable]
    public class ADData
    {
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
        public string Price { get; set; }
        public string Adress { get; set; }
        public string Images { get; set; }
        //public List<Image> Images { get; set; } = new List<Image>();
        public string VideoUrl { get; set; }

        //Вторичные для телефона
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string MemorySize { get; set; }
        public string RamSize { get; set; }

        public ADData() { }
        public ADData(string Id, string Title, string DateBegin, string DateEnd, string AdStatus,
            string Category, string GoodsType, string Condition, string Description,
            string ContactMethod, string Price, string Adress, string Images, string VideoUrl,
            string Vendor, string Model, string Color, string MemorySize, string RamSize)
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
            this.Price = Price;
            this.Adress = Adress;
            this.Images = Images;
            this.VideoUrl = VideoUrl;
            this.Vendor = Vendor;
            this.Model = Model;
            this.Color = Color;
            this.RamSize = RamSize;
            this.MemorySize = MemorySize;
        }
    }
}