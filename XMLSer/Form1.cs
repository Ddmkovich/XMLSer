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

namespace XMLSer
{
    public partial class Form1 : Form
    {
        List<string> images = new List<string>();
        OpenFileDialog _fileDialog = new OpenFileDialog();
        Ad ad = new Ad();
        Dictonary dictonary = new Dictonary();
        public Form1()
        {
            InitializeComponent();
            ClearInput();
        }
        private void ClearInput()
        { 
            //Очищает поля для ввода
            images.Clear();
            tbID.Clear();
            dtpBeg.ResetText();
            dtpEnd.ResetText();
            tbTitle.Clear();
            tbDescription.Clear();
            tbPrice.Clear();
            tbVideoURL.Clear();
            _fileDialog.Reset();
            cmbCategory.ResetText();
            cmbADStatus.ResetText();
            cmbColor.ResetText();
            cmbCondition.ResetText();
            cmbContactMethod.ResetText();
            cmbGoodsType.ResetText();
            cmbModel.ResetText();
            cmbRAM.ResetText();
            cmbROM.ResetText();
            cmbVendor.ResetText();
            cmbAdType.ResetText();
            cmbApparel.ResetText();
            cmbApparelType.ResetText();
            cmbSize.ResetText();
        }
        private void Serialize(Ads ad)
        {
            //Сериализирует все объекты из ListView в xml файл
            XmlSerializer xmlSerializer = new XmlSerializer(ad.GetType());
            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            using (FileStream fs = new FileStream("Ads.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, ad, xns);

            }

        }
        private Ads Deserialize()
        {
            //Десериализирует компоненты из xml файла в ListView
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Ads));
            using (FileStream fs = new FileStream("Ads.xml", FileMode.OpenOrCreate))
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
                    ad.Apparel = cmbApparel.Text;
                    ad.ApparelType = cmbApparelType.Text;
                    ad.Size = cmbSize.Text;
                }
               
            }
            else
            {
                //Добавляет новые объекты в ListView
                ad = new Ad(tbID.Text, tbTitle.Text, dtpBeg.Text, dtpEnd.Text, cmbADStatus.Text,
               cmbCategory.Text, cmbGoodsType.Text, cmbCondition.Text, tbDescription.Text, cmbContactMethod.Text,
               tbPrice.Text, tbAdress.Text, images, tbVideoURL.Text = "url=" + '\u0022' + tbVideoURL.Text + '\u0022', cmbVendor.Text, cmbModel.Text, cmbColor.Text,
               cmbROM.Text, cmbRAM.Text , cmbAdType.Text,cmbApparel.Text,cmbApparelType.Text,cmbSize.Text);
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
                    cmbApparel.Text = ad.Apparel;
                    cmbApparelType.Text = ad.ApparelType;
                    cmbSize.Text = ad.Size;
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
            var xml = File.ReadAllText("Ads.xml");
            var correctedXml = xml.Replace("<Image>", "<Image ");
            xml = correctedXml;
            xml = xml.Replace("</Image>", "/>");
            File.WriteAllText("Ads.xml", xml);
        }

        private void btDeserialize_Click(object sender, EventArgs e)
        {
            //Кнопка которая активирует метод десериализации Объявлений
            //Возваращет файлу первоначальный вид для корректной десериализации
            var xml = File.ReadAllText("Ads.xml");
            var correctedXml = xml.Replace("<Image ", "<Image>");
            xml = correctedXml;
            xml = xml.Replace('\u0022'+"/>",'\u0022'+"</Image>");
            File.WriteAllText("Ads.xml", xml);

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
            

        }

        private void cmbGoodsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbApparel.Items.Clear();
            if (cmbGoodsType.Text == "Женская одежда")
            {
                cmbApparel.Items.AddRange(dictonary.womenApparelNames);
            }
            else if (cmbGoodsType.Text == "Мужская одежда")
            {
                cmbApparel.Items.AddRange(dictonary.menApparelNames);
            }
            else if (cmbGoodsType.Text == "Аксессуары")
            {

                cmbApparel.Items.AddRange(dictonary.accesApparelNames);
            }
            else
            {
                cmbApparel.Items.Add("");
            }
        }

        private void cmbApparel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbApparelType.Items.Clear();
            if (cmbApparel.Text == "Верхняя одежда" && cmbGoodsType.Text == "Женская одежда")
            {
                cmbApparelType.Items.AddRange(dictonary.womenTopApparelNames);
            }
            else if (cmbApparel.Text == "Верхняя одежда" && cmbGoodsType.Text == "Мужская одежда")
            {
                cmbApparelType.Items.AddRange(dictonary.menTopApparelNames);
            }
            else
            {
                cmbApparelType.Items.Add("");
            }

           
        }

        private void cmbSize_MouseEnter(object sender, EventArgs e)
        {
            cmbSize.Items.Clear();
            if (cmbApparel.Text == "Верхняя одежда" && cmbGoodsType.Text == "Женская одежда")
            {
                cmbSize.Items.AddRange(dictonary.womenTopSizeNames);
            }
            else if (cmbApparel.Text == "Верхняя одежда" && cmbGoodsType.Text == "Мужская одежда")
            {
                cmbSize.Items.AddRange(dictonary.menTopSizeNames);
            }
            else
            {
                cmbSize.Items.Add("");
            }
        }

        private void panelDnD_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                _fileDialog.Multiselect = true;
                _fileDialog.Filter = "Image Files (*.bmp,*.png,*.jpg,*.jpeg)|*.bmp;*.png;*.jpg;*.jpeg";
                if (_fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
    }
}
