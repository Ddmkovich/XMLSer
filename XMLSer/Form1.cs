using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace XMLSer
{
    public partial class Form1 : Form
    {
        List<string> images = new List<string>();
        OpenFileDialog openFileDialog = new OpenFileDialog();
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
            openFileDialog.Reset();
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
            tbImgName.Clear();
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
                        tbImgName.Text += x;
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

        private void btAddImage_Click(object sender, EventArgs e)
        {
            //Кнопка которая позволяет добавить картинки
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                foreach (var x in openFileDialog.FileNames)
                {
                    tbImgName.Text += openFileDialog.FileName;
                    string image = "url=" + '\u0022' + x + '\u0022';
                    images.Add(image);
                    
                }

            }
        }

        //Далее события которые активирует определённый справочник при определённом выборе
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGoodsType.Items.Clear();
            if (cmbCategory.Text == "Телефоны")
            {
                cmbGoodsType.Items.AddRange(dictonary.phonesGoods);
                cmbVendor.Enabled = true;
                cmbModel.Enabled = true;
                cmbColor.Enabled = true;
                cmbRAM.Enabled = true;
                cmbROM.Enabled = true;
            }
            else if (cmbCategory.Text == "Аудио и видео")
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
            else
            {
                cmbGoodsType.Items.Add("");
                cmbVendor.Enabled = false;
                cmbModel.Enabled = false;
                cmbColor.Enabled = false;
                cmbRAM.Enabled = false;
                cmbROM.Enabled = false;
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
    }
}
