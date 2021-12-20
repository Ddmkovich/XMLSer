namespace XMLSer.Classes
{
    public class LapTemplates
    {
        public int Id { get; set; }
        public string titleApp { get; set; }
        public string title { get; set; }
        public string descr { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        LapTemplates() { }
        LapTemplates(int Id, string titleApp,string title,string descr,string brand,string model)
        {
            this.Id = Id;
            this.titleApp = titleApp;
            this.title = title;
            this.descr = descr;
            this.brand = brand;
            this.model = model;
        }

    }
    public class LapPhoto
    {
        public string URL { get; set; }
        public int LapTampID { get; set; }
        LapPhoto() { }
        LapPhoto(string URL, int LapTampID)
        {
            this.URL = URL;
            this.LapTampID = LapTampID;
        }

    }
    public class PhoneTemplates
    {
        public int Id { get; set; }
        public string titleApp { get; set; }
        public string title { get; set; }
        public string descr { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        PhoneTemplates() { }
        PhoneTemplates(int Id, string titleApp, string title, string descr, string brand, string model)
        {
            this.Id = Id;
            this.titleApp = titleApp;
            this.title = title;
            this.descr = descr;
            this.brand = brand;
            this.model = model;
        }

    }
    public class PhonePhoto
    {
        public string URL { get; set; }
        public int phoneTempID { get; set; }
        PhonePhoto() { }
        PhonePhoto(string URL, int phoneTempID)
        {
            this.URL = URL;
            this.phoneTempID = phoneTempID;
        }

    }
    public class PCTemplates
    {
        public int Id { get; set; }
        public string titleApp { get; set; }
        public string title { get; set; }
        public string descr { get; set; }
        PCTemplates() { }
        PCTemplates(int Id, string titleApp, string title, string descr)
        {
            this.Id = Id;
            this.titleApp = titleApp;
            this.title = title;
            this.descr = descr;
        }

    }
    public class PCPhoto
    {
        public string URL { get; set; }
        public int pcTempID { get; set; }
        PCPhoto() { }
        PCPhoto(string URL, int pcTempID)
        {
            this.URL = URL;
            this.pcTempID = pcTempID;
        }

    }
    public class ToolTemplates
    {
        public int Id { get; set; }
        public string titleApp { get; set; }
        public string title { get; set; }
        public string descr { get; set; }
        ToolTemplates() { }
        ToolTemplates(int Id, string titleApp, string title, string descr)
        {
            this.Id = Id;
            this.titleApp = titleApp;
            this.title = title;
            this.descr = descr;
        }

    }
    public class ToolPhoto
    {
        public string URL { get; set; }
        public int toolTempID { get; set; }
        ToolPhoto() { }
        ToolPhoto(string URL, int toolTempID)
        {
            this.URL = URL;
            this.toolTempID = toolTempID;
        }

    }
    public class JewelryTemplates
    {
        public int Id { get; set; }
        public string titleApp { get; set; }
        public string title { get; set; }
        public string descr { get; set; }
        JewelryTemplates() { }
        JewelryTemplates(int Id, string titleApp, string title, string descr)
        {
            this.Id = Id;
            this.titleApp = titleApp;
            this.title = title;
            this.descr = descr;
        }

    }
    public class JewelryPhoto
    {
        public string URL { get; set; }
        public int jewelryTempID { get; set; }
        JewelryPhoto() { }
        JewelryPhoto(string URL, int jewelryTempID)
        {
            this.URL = URL;
            this.jewelryTempID = jewelryTempID;
        }

    }
}
