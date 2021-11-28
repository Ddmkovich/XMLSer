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
        public Form1()
        {
            InitializeComponent();
            ClearInput();
        }
        private void ClearInput()
        {
            tbID.Clear();
            tbDateBeg.Clear();
            tbDateEnd.Clear();
            tbTitle.Clear();
            tbDescription.Clear();
            tbPrice.Clear();
            tbVideoURL.Clear();
            ofdImages.Reset();
            cmbCategory.SelectedIndex = 0;
            cmbADStatus.SelectedIndex = 0;
            cmbColor.SelectedIndex = 0;
            cmbCondition.SelectedIndex = 0;
            cmbContactMethod.SelectedIndex = 0;
            cmbGoodsType.SelectedIndex = 0;
            cmbModel.SelectedIndex = 0;
            cmbRAM.SelectedIndex = 0;
            cmbROM.SelectedIndex = 0;
            cmbVendor.SelectedIndex = 0;            
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            Ad ad = new Ad(tbID.Text, tbTitle.Text, tbDateBeg.Text, tbDateEnd.Text, cmbADStatus.Text,
                cmbCategory.Text, cmbGoodsType.Text, cmbCondition.Text, tbDescription.Text, cmbContactMethod.Text,
                tbPrice.Text, tbAdress.Text, images , tbVideoURL.Text = "url="+'\u0022'+ tbVideoURL.Text +'\u0022', cmbVendor.Text, cmbModel.Text, cmbColor.Text,
                cmbROM.Text, cmbRAM.Text);
            Add(ad);
            ClearInput();
        }

        private void ADsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ADsList.SelectedItems.Count==1)
            {
                Ad ad = (Ad)ADsList.SelectedItems[0].Tag;
                if (ad!=null)
                {
                    tbID.Text = ad.Id;
                    tbTitle.Text = ad.Title;
                    tbDateBeg.Text = ad.DateBegin;
                    tbDateEnd.Text = ad.DateEnd;
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
                }
                 
            }
            else if (ADsList.SelectedItems.Count==0)
            {
                ClearInput();
            }
        }

        private void Serialize(Ads ad)
        {
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
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Ads));
            using (FileStream fs = new FileStream("Ads.xml", FileMode.OpenOrCreate))
            {
                return (Ads)xmlSerializer.Deserialize(fs);

            }
        }
        private void Add(Ad ad)
        {
            ListViewItem LVI = new ListViewItem(ad.Title);
            LVI.Tag = ad;
            ADsList.Items.Add(LVI);
        }
        private void btSerialize_Click(object sender, EventArgs e)
        {
            Ads ad = new Ads();
            foreach (ListViewItem item in ADsList.Items)
            {
                if (item.Tag!=null)
                {
                    ad.ADList.Add((Ad)item.Tag);
                }
            }
            Serialize(ad);
            var xml = File.ReadAllText("Ads.xml");
            var firstImageIdx = xml.IndexOf("<Image>");
            var secondImageIdx = xml.IndexOf("</Image>", firstImageIdx + 1);

            var correctedXml = xml.Replace("<Image>", "<Image ");
            xml = correctedXml;
            xml = xml.Replace("</Image>", "/>");

            File.WriteAllText("Ads.xml", xml);
        }

        private void btDeserialize_Click(object sender, EventArgs e)
        {
            ADsList.Clear();
            ClearInput();
          Ads aDs =  Deserialize();
            foreach (Ad ad in aDs.ADList)
            {
                Add(ad);
            }
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
            
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                foreach (var x in openFileDialog.FileNames)
                {
                    tbImgName.Text += openFileDialog.FileName;
                    string image= "url=" + '\u0022' + x + '\u0022';
                    images.Add(image);
                }

            }
        }

        
    }
}
