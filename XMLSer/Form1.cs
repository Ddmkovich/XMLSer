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
    public partial class Form1 : Form
    {
        List<string> images = new List<string>();
        OpenFileDialog _fileDialog = new OpenFileDialog();
        Ad ad = new Ad();
        Dictonary dictonary = new Dictonary();
        string cs = @"URI=file:Templates.db";
        public Form1()
        {
            InitializeComponent();
            ClearInput();
            dtpBeg.CustomFormat = "dd.MM.yy H:mm:ss";
            dtpEnd.CustomFormat = "dd.MM.yy H:mm:ss";
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
        }
        private void Serialize(Ads ad)
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
        private Ads Deserialize()
        {
            //Десериализирует компоненты из xml файла в ListView
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Ads));
            using (FileStream fs = new FileStream("Avito.xml", FileMode.OpenOrCreate))
            {
                return (Ads)xmlSerializer.Deserialize(fs);

            }
        }
        private void Add(Ad ad)
        {
            //Добавляет объекст в ListView и называет в соответствии с заголовком объявления
            ListViewItem LVI = new ListViewItem(ad.Title);
            LVI.Tag = ad;
            ADsList.Items.Add(LVI);
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            //Сохранает измения выбранного в ListView объекта
            tbID.Text = DateTime.Now.ToString();
            if (ADsList.SelectedItems.Count == 1)
            {
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
            else
            {
                //Добавляет новые объекты в ListView
                ad = new Ad(tbID.Text, tbTitle.Text, dtpBeg.Text, dtpEnd.Text, cmbADStatus.Text,
               cmbCategory.Text, cmbGoodsType.Text, cmbCondition.Text, tbDescription.Text, cmbContactMethod.Text,tbManager.Text,tbPhone.Text,
               tbPrice.Text, tbAdress.Text, images, tbVideoURL.Text = "url=" + '\u0022' + tbVideoURL.Text + '\u0022', cmbVendor.Text, cmbModel.Text, cmbColor.Text,
               cmbROM.Text, cmbRAM.Text , cmbAdType.Text);
                Add(ad);
                ClearInput();
            }
           
            
        }

        private void ADsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //При выборе предмета в ListView выводит заполненные данные в поля
            if (ADsList.SelectedItems.Count == 1)
            {
                Ad ad = (Ad)ADsList.SelectedItems[0].Tag;
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
                       
                    }
                    cmbAdType.Text = ad.AdType;
                }

            }
            else if (ADsList.SelectedItems.Count == 0)
            {
                //Очищает поля если ничего не выбрано
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
            Serialize(ad);
            //Подгоняет xml файл под Авито стандарты
            var xml = File.ReadAllText("Avito.xml");
            var correctedXml = xml.Replace("<Image>", "<Image ");
            xml = correctedXml;
            xml = xml.Replace("</Image>", "/>");
            File.WriteAllText("Avito.xml", xml);
            correctedXml = xml.Replace("<ADList>", "");
            xml = correctedXml;
            xml = xml.Replace("</ADList>", "");
            File.WriteAllText("Yandex.xml", xml);
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
            correctedXml = xml.Replace("<Ad>", " <ADList>\n<Ad>");
            xml = correctedXml;
            xml = xml.Replace("</Ad>", "</Ad>\n</ADList>");
            File.WriteAllText("Yandex.xml", xml);

            ADsList.Clear();
            ClearInput();
            Ads aDs = Deserialize();
            foreach (Ad ad in aDs.ADList)
            {
                Add(ad);
            }
        }

        //Далее события которые активирует определённый справочник при определённом выборе
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
        private void panelDnD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
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
                            //скопируем URL в буфер обмена
                            Clipboard.SetData(DataFormats.Text, (Object)UploadedImageData.data.image.url);
                            images.Add("url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022');
                            
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelDnD_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<string> filepaths = new List<string>();
                foreach (var obj in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    if (Directory.Exists(obj))
                    {
                        filepaths.AddRange(Directory.GetFiles(obj, "*.*", SearchOption.AllDirectories));
                    }
                    else
                    {
                        filepaths.Add(obj);
                    }

                }
                foreach (var fileInList in filepaths)
                {
                    //массив байтов файла
                    byte[] imageArray = File.ReadAllBytes(fileInList);
                    //конвертируем в base64
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
                        //скопируем URL в буфер обмена
                        Clipboard.SetData(DataFormats.Text, (Object)UploadedImageData.data.image.url);
                        images.Add("url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022');
                        //MessageBox.Show(UploadedImageData.data.image.url);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void panelDnD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                label26.Text = "Бросай!";
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panelDnD_DragLeave(object sender, EventArgs e)
        {
            label26.Text = "Перетащи сюда файлы!";
        }

        private void btAddTemplate_Click(object sender, EventArgs e)
        {
            EdAddTemplate edAddTemplate = new EdAddTemplate();
            edAddTemplate.ShowDialog();
        }
        private void UploadTemplates()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM "+comboBox1.Text+"Templates";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbTemplates.Items.Add(rdr.GetString(1));
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTemplates.Items.Clear();
            UploadTemplates();
            if (comboBox1.Text == "jewelry")
            {
                label27.Text = "Драгоценности";
                cmbCategory.Text = "Часы и украшения";
                cmbCondition.Text = "Б/у";
                cmbAdType.Text = "Товар приобретен на продажу";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (comboBox1.Text == "pc")
            {
                label27.Text = "Настольный ПК";
                cmbCategory.Text = "Настольные компьютеры";
                cmbCondition.Text = "Б/у";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (comboBox1.Text == "lap")
            {
                label27.Text = "Ноутбук";
                cmbCategory.Text = "Ноутбуки";
                cmbCondition.Text = "Б/у";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (comboBox1.Text == "phone")
            {
                label27.Text = "Телефон";
                cmbCategory.Text = "Телефоны";
                cmbCondition.Text = "Б/у";
                cmbADStatus.Text = "Free";
                cmbContactMethod.Text = "По телефону и в сообщениях";
            }
            else if (comboBox1.Text == "tool")
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
            string stm = "SELECT * FROM " + comboBox1.Text + "Templates where " + comboBox1.Text + "Templates.titleApp=='" + cmbTemplates.Text+"'";
            var cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                tbTitle.Text = rdr.GetString(2);
                tbDescription.Text = rdr.GetString(3);
            }
            con.Close();
        }
        private void btAddImageTempl_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
