using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLSer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            tbImages.Clear();
            
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            Ad ad = new Ad(tbID.Text, tbTitle.Text, tbDateBeg.Text, tbDateEnd.Text, cmbADStatus.Text,
                cmbCategory.Text, cmbGoodsType.Text, cmbCondition.Text, tbDescription.Text, cmbContactMethod.Text,
                tbPrice.Text, tbAdress.Text, tbImages.Text, tbVideoURL.Text, cmbVendor.Text, cmbModel.Text, cmbColor.Text,
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
                    tbAdress.Text = ad.Adress;
                    tbImages.Text = ad.Images;
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

        private void Serialize(ADs ad)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ad.GetType());
            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            using (FileStream fs = new FileStream("Ads.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, ad, xns);
               
            }
           
        }
        private ADs Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ADs));
            using (FileStream fs = new FileStream("Ads.xml", FileMode.OpenOrCreate))
            {
                return (ADs)xmlSerializer.Deserialize(fs);

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
            ADs ad = new ADs();
            foreach (ListViewItem item in ADsList.Items)
            {
                if (item.Tag!=null)
                {
                    ad.ADList.Add((Ad)item.Tag);
                }
            }
            Serialize(ad);
        }

        private void btDeserialize_Click(object sender, EventArgs e)
        {
            ClearInput();
          ADs aDs =  Deserialize();
            foreach (Ad ad in aDs.ADList)
            {
                Add(ad);
            }
        }
    }
}
