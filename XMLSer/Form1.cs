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
            ADData ad = new ADData(tbID.Text, tbTitle.Text, tbDateBeg.Text, tbDateEnd.Text, cmbADStatus.Text,
                cmbCategory.Text, cmbGoodsType.Text, cmbCondition.Text, tbDescription.Text, cmbContactMethod.Text,
                tbPrice.Text, tbAdress.Text, tbImages.Text, tbVideoURL.Text, cmbVendor.Text, cmbModel.Text, cmbColor.Text,
                cmbROM.Text, cmbRAM.Text);
            ListViewItem LVI = new ListViewItem(ad.Title);
            LVI.Tag = ad;
            ADsList.Items.Add(LVI);
            ClearInput();
        }

        private void ADsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ADsList.SelectedItems.Count==1)
            {
                ADData ad = (ADData)ADsList.SelectedItems[0].Tag;
                if (ad!=null)
                {

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
            using (FileStream fs = new FileStream("AdXML", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, ad, xns);
               
            }
           
        }
        private void btSerialize_Click(object sender, EventArgs e)
        {
            ADs ad = new ADs();
            foreach (ListViewItem item in ADsList.Items)
            {
                if (item.Tag!=null)
                {
                    ad.AdsList.Add((ADData)item.Tag);
                }
            }
            Serialize(ad);
        }
    }
}
