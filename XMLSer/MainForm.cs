using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace XMLSer
{
    public partial class MainForm : Form
    {
        List<string> images = new List<string>();
        List<string> youlaLabels = new List<string>();
        OpenFileDialog _fileDialog = new OpenFileDialog();
        Classes.XMLSerDeser XMLSerDeser = new Classes.XMLSerDeser();
        Ad ad = new Ad();
        offer offer = new offer();
        Dictonary dictonary = new Dictonary();
        string cs = @"URI=file:Templates.db";
        public MainForm()
        {
            InitializeComponent();
            ClearInput();
            dtpBeg.CustomFormat = "yyyy.MM.ddTH:mm:ss";
            dtpEnd.CustomFormat = "yyyy.MM.ddTH:mm:ss";
        }
        private void ClearInput()
        { 
            //Очищает поля для ввода
            images.Clear();
            tbID.Clear();
            _fileDialog.Reset();
            cmbModel.ResetText();
            cmbRAM.ResetText();
            cmbROM.ResetText();
            cmbVendor.ResetText();
            tbIImgURL.Clear();
            tbVideoURL.Clear();
        }
        
        private void AddAvito(Ad ad)
        {
            //Добавляет объект в ListView и называет в соответствии с заголовком объявления
            ListViewItem LVIAvito = new ListViewItem(ad.Title);
            LVIAvito.Tag = ad;
            ADsList.Items.Add(LVIAvito);
        }
        private void AddYoula(offer offer)
        {
            //Добавляет объект в ListView и называет в соответствии с заголовком объявления
            ListViewItem LVIYoula = new ListViewItem(offer.name);
            LVIYoula.Tag = offer;
            youlaList.Items.Add(LVIYoula);
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            //Сохранает измения выбранного в ListView объекта
            tbID.Text = DateTime.Now.ToString();
            if (ADsList.SelectedItems.Count == 1)
            {
                ClearInput();
                Ad ad = (Ad)ADsList.SelectedItems[0].Tag;
                if (ad != null)
                {
                    ad.Id = tbID.Text;
                    ad.Title = tbTitle.Text;
                    ad.DateBegin = dtpBeg.Text;
                    ad.DateEnd = dtpEnd.Text;
                    ad.AdStatus = cmbADStatus.Text;
                    ad.Category = cmbCategory.Text;
                    ad.GoodsType = cmbGoodsType.Text;
                    ad.Condition = cmbCondition.Text;
                    ad.Description = tbDescription.Text;
                    ad.ContactMethod = cmbContactMethod.Text;
                    ad.Price = tbPrice.Text;
                    ad.Address = tbAdress.Text;
                    ad.VideoUrl = tbVideoURL.Text;
                    ad.Vendor = cmbVendor.Text;
                    ad.Images = images; 
                    ad.Model = cmbModel.Text;
                    ad.Color = cmbColor.Text;
                    ad.RamSize = cmbRAM.Text;
                    ad.MemorySize = cmbROM.Text;
                    ad.AdType = cmbAdType.Text;
                }
               
            }
            else if (youlaList.SelectedItems.Count == 1)
            {
                ClearInput();
                offer offer = (offer)youlaList.SelectedItems[0].Tag;
                if (ad != null)
                {
                    offer.name = tbTitle.Text;
                    offer.youlaCategoryId = cmbCategory.Text;
                    offer.youlaSubcategoryId = cmbGoodsType.Text;
                    offer.address = tbAdress.Text;
                    offer.price = tbPrice.Text;
                    offer.phone = tbPhone.Text;
                    offer.managerName = tbManager.Text;
                    offer.Images = images;
                    offer.description = tbDescription.Text;

                }

            }
            else
            {
                //Добавляет новые объекты в ListView
                ad = new Ad(tbID.Text, tbTitle.Text, dtpBeg.Text, dtpEnd.Text, cmbADStatus.Text,
               cmbCategory.Text, cmbGoodsType.Text, cmbCondition.Text, tbDescription.Text, cmbContactMethod.Text,tbManager.Text,tbPhone.Text,
               tbPrice.Text, tbAdress.Text, images, tbVideoURL.Text = "url=" + '\u0022' + tbVideoURL.Text + '\u0022', cmbVendor.Text, cmbModel.Text, cmbColor.Text,
               cmbROM.Text, cmbRAM.Text , cmbAdType.Text);
                offer = new offer(tbTitle.Text,cmbCategory.Text,cmbGoodsType.Text,tbDescription.Text, tbManager.Text, tbPhone.Text,tbPrice.Text,tbAdress.Text,images);
                AddAvito(ad);
                AddYoula(offer);
                ClearInput();
            }
           
            
        }

        private void ADsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //При выборе предмета в ListView выводит заполненные данные в поля
            if (ADsList.SelectedItems.Count == 1)
            {
                Ad ad = (Ad)ADsList.SelectedItems[0].Tag;
                btCreate.Text = "Сохранить изменения Авито";
                if (ad != null)
                {
                    tbID.Text = ad.Id;
                    tbTitle.Text = ad.Title;
                    dtpBeg.Text = ad.DateBegin;
                    dtpEnd.Text = ad.DateEnd;
                    cmbADStatus.Text = ad.AdStatus;
                    cmbCategory.Text = ad.Category;
                    cmbGoodsType.Text = ad.GoodsType;
                    cmbCondition.Text = ad.Condition;
                    tbDescription.Text = ad.Description;
                    cmbContactMethod.Text = ad.ContactMethod;
                    tbPrice.Text = ad.Price;
                    tbAdress.Text = ad.Address;
                    tbVideoURL.Text = ad.VideoUrl;
                    cmbVendor.Text = ad.Vendor;
                    cmbModel.Text = ad.Model;
                    cmbColor.Text = ad.Color;
                    cmbRAM.Text = ad.RamSize;
                    cmbROM.Text = ad.MemorySize;
                    foreach (var x in ad.Images)
                    {
                       images.Add(x);
                        tbIImgURL.Text += x.ToString() + "\n";
                    }
                    cmbAdType.Text = ad.AdType;
                }

            }
            else if (ADsList.SelectedItems.Count == 0)
            {
                //Очищает поля если ничего не выбрано
                btCreate.Text = "Сохранить";
                ClearInput();
            }
        }
        private void youlaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (youlaList.SelectedItems.Count == 1)
            {
                ClearInput();
                offer offer = (offer)youlaList.SelectedItems[0].Tag;
                btCreate.Text = "Сохранить изменения Юла";
                if (ad != null)
                {
                    tbTitle.Text = offer.name;
                    cmbCategory.Text = offer.youlaCategoryId;
                    cmbGoodsType.Text = offer.youlaSubcategoryId;
                    tbAdress.Text = offer.address;
                    tbPrice.Text = offer.price;
                    tbPhone.Text = offer.phone;
                    tbManager.Text = offer.managerName;
                    foreach (var x in offer.Images)
                    {
                        images.Add(x);
                        tbIImgURL.Text += x.ToString() + "\n";
                    }
                    tbDescription.Text = offer.description;

                }

            }
            else if (ADsList.SelectedItems.Count == 0)
            {
                //Очищает поля если ничего не выбрано
                btCreate.Text = "Сохранить";
                ClearInput();
            }
        }
        private void btSerialize_Click(object sender, EventArgs e)
        {
            //Кнопка которая активирует метод сериализации Объявлений
            Ads ad = new Ads();
            foreach (ListViewItem item in ADsList.Items)
            {
                if (item.Tag != null)
                {
                    ad.ADList.Add((Ad)item.Tag);
                    
                }
            }
            yml_catalog offers = new yml_catalog();
            foreach (ListViewItem item in youlaList.Items)
            {
                if (item.Tag != null)
                {
                    offers.offerList.Add((offer)item.Tag);

                }
            }
            XMLSerDeser.SerializeAvito(ad); //Передаёт данные в класс XMLSerDeser, который сериализует данные
            XMLSerDeser.SerializeYoula(offers);
            //Подгоняет xml файл под Авито стандарты
            var xml = File.ReadAllText("Avito.xml");
            var correctedXml = xml.Replace("<Image>", "<Image ");
            xml = correctedXml;
            xml = xml.Replace("</Image>", "/>");
            File.WriteAllText("Avito.xml", xml);
            correctedXml = xml.Replace("<ADList>", "");
        }

        private void btDeserialize_Click(object sender, EventArgs e)
        {
            //Кнопка которая активирует метод десериализации Объявлений
            //Возваращет файлу первоначальный вид для корректной десериализации
            var xml = File.ReadAllText("Avito.xml");
            var correctedXml = xml.Replace("<Image ", "<Image>");
            xml = correctedXml;
            xml = xml.Replace('\u0022'+"/>",'\u0022'+"</Image>");
            File.WriteAllText("Avito.xml", xml);

            ADsList.Clear();
            ClearInput();
            //Передаёт данные в класс XMLSerDeser, который десериализует данные
            Ads aDs = XMLSerDeser.DeserializeAvito();
            foreach (Ad ad in aDs.ADList)
            {
                AddAvito(ad);
            }
            yml_catalog offers = XMLSerDeser.DeserializeYoula();
            foreach (offer offer in offers.offerList)
            {
                AddYoula(offer);
            }

        }
        private void panelDnD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                images.Clear();
                tbIImgURL.Clear();
                _fileDialog.Multiselect = true;
                _fileDialog.Filter = "Image Files (*.bmp,*.png,*.jpg,*.jpeg)|*.bmp;*.png;*.jpg;*.jpeg";
                if (_fileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var x in _fileDialog.FileNames)
                    {
                        byte[] imageArray = File.ReadAllBytes(x);
                        string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                        using (WebClient client = new WebClient())
                        {
                            //задаем параметры для коллекции
                            NameValueCollection param = new NameValueCollection();
                            param.Add("key", "5422e9f2d271f43564f1bc9511c938e7");
                            //удалится через 3 дня
                            param.Add("expiration", "259200");
                            param.Add("image", base64ImageRepresentation);
                            //делаем запрос методом POST и получем массив байтов
                            var response = client.UploadValues("https://api.imgbb.com/1/upload", "POST", param);
                            //декодируем
                            var jsonResponse = Encoding.Default.GetString(response);
                            //десериализуем
                            JsonDeser UploadedImageData = JsonConvert.DeserializeObject<JsonDeser>(jsonResponse);
                            //скопируем URL в буфер обмена
                            Clipboard.SetData(DataFormats.Text, (Object)UploadedImageData.data.image.url);
                            images.Add("url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022');
                            tbIImgURL.Text += ("url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022');
                            
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btAddTemplate_Click(object sender, EventArgs e)
        {
            EdAddTemplate edAddTemplate = new EdAddTemplate();
            edAddTemplate.ShowDialog();
        }
        //Загрузка списка шаблонов и их вставка в combobox для шаблонов
        private void UploadTemplates()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM "+cmbTemplateFrom.Text+"Templates";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbTemplates.Items.Add(rdr.GetString(1));
            }
            con.Close();
        }

        //Дальше работа с комбобоксами и классом Dictionary
        private void cmbTemplateFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTemplates.Items.Clear();
            UploadTemplates();
            if (cmbTemplateFrom.Text == "jewelry")
            {
                label27.Text = "Драгоценности";
                cmbCategory.Text = "Часы и украшения";
                cmbCondition.Text = "Б/у";
                cmbAdType.Text = "Товар приобретен на продажу";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (cmbTemplateFrom.Text == "pc")
            {
                label27.Text = "Настольный ПК";
                cmbCategory.Text = "Настольные компьютеры";
                cmbCondition.Text = "Б/у";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (cmbTemplateFrom.Text == "lap")
            {
                label27.Text = "Ноутбук";
                cmbCategory.Text = "Ноутбуки";
                cmbCondition.Text = "Б/у";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (cmbTemplateFrom.Text == "phone")
            {
                label27.Text = "Телефон";
                cmbCategory.Text = "Телефоны";
                cmbCondition.Text = "Б/у";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (cmbTemplateFrom.Text == "tool")
            {
                label27.Text = "Инструмент";
                cmbCategory.Text = "Ремонт и строительство";
                cmbCondition.Text = "Б/у";
                cmbAdType.Text = "Товар приобретен на продажу";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else
            {
                label27.Text = "Выберите значение";
            }
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM " + cmbTemplateFrom.Text + "Templates where " + cmbTemplateFrom.Text + "Templates.titleApp=='" + cmbTemplates.Text+"'";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                tbTitle.Text = rdr.GetString(2);
                tbDescription.Text = rdr.GetString(3);
            }
            con.Close();
        }
        
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGoodsType.Items.Clear();
            cmbVendor.Enabled = false;
            cmbModel.Enabled = false;
            cmbColor.Enabled = false;
            cmbRAM.Enabled = false;
            cmbROM.Enabled = false;
            if (cmbCategory.Text == "Телефоны")
            {
                cmbGoodsType.Items.AddRange(dictonary.phonesGoods);
                cmbVendor.Enabled = true;
                cmbModel.Enabled = true;
                cmbColor.Enabled = true;
                cmbRAM.Enabled = true;
                cmbROM.Enabled = true;
            }
            else
            {
                cmbGoodsType.Items.Add("");
                cmbVendor.Enabled = false;
                cmbModel.Enabled = false;
                cmbColor.Enabled = false;
                cmbRAM.Enabled = false;
                cmbROM.Enabled = false;
            }
            if (cmbCategory.Text == "Аудио и видео")
            {
                cmbGoodsType.Items.AddRange(dictonary.audVidNames);
            }
            else if (cmbCategory.Text == "Фототехника")
            {
                cmbGoodsType.Items.AddRange(dictonary.phoTechNames);
            }
            else if (cmbCategory.Text == "Игры, приставки и программы")
            {
                cmbGoodsType.Items.AddRange(dictonary.gamConsProgNames);
            }
            else if (cmbCategory.Text == "Оргтехника и расходники")
            {
                cmbGoodsType.Items.AddRange(dictonary.ofEquipConsumNames);
            }
            else if (cmbCategory.Text == "Планшеты и электронные книги")
            {
                cmbGoodsType.Items.AddRange(dictonary.tablBooksNames);
            }
            else if (cmbCategory.Text == "Ноутбуки")
            {
                cmbGoodsType.Items.AddRange(dictonary.laptopNames);
            }
            else if (cmbCategory.Text == "Одежда, обувь, аксессуары")
            {
                cmbGoodsType.Items.AddRange(dictonary.manWomenAccesNames);
            }
            else if (cmbCategory.Text == "Часы и украшения")
            {
                cmbGoodsType.Items.AddRange(dictonary.clockFineryNames);
            }
            else if (cmbCategory.Text == "Ремонт и строительство")
            {
                cmbGoodsType.Items.AddRange(dictonary.toolNames);
            }
        }

       
    }
}
