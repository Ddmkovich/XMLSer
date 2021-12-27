using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Data.SQLite;


namespace XMLSer
{
    public partial class EdAddTemplate : Form
    {
        //OpenFileDialog _fileDialog = new OpenFileDialog();
        //List<string> images = new List<string>();
        string cs = @"URI=file:Templates.db";
        public EdAddTemplate()
        {
            InitializeComponent();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (cmbTables.Text=="")
            {
                MessageBox.Show("Сделайте выбор в первой ячейке");
            }
            else
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO " + cmbTables.Text + "Templates (titleApp,title,descr) VALUES('" + tbTitleApp.Text + "','" + tbTitle.Text + "','" + tbDescr.Text + "')";
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "SELECT id FROM " + cmbTables.Text + "Templates where " + cmbTables.Text + "Templates.titleApp = '" + tbTitleApp.Text + "'";
                //object gotID = cmd.ExecuteScalar();
                //foreach (string x in images)
                //{
                //    //MessageBox.Show(x, rdr.GetInt32(0).ToString());
                //    cmd.CommandText = "INSERT INTO " + cmbTables.Text + "Photoes(photoURL," + cmbTables.Text + "TempID) VALUES('" + x + "','" + Convert.ToInt32(gotID) + "')";
                //    cmd.ExecuteNonQuery();
                //}
                con.Close();
            }
        }

        //private void panelDnD_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        _fileDialog.Multiselect = true;
        //        _fileDialog.Filter = "Image Files (*.bmp,*.png,*.jpg,*.jpeg)|*.bmp;*.png;*.jpg;*.jpeg";
        //        if (_fileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            foreach (var x in _fileDialog.FileNames)
        //            {
        //                byte[] imageArray = File.ReadAllBytes(x);
        //                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
        //                using (WebClient client = new WebClient())
        //                {
        //                    //задаем параметры для коллекции
        //                    NameValueCollection param = new NameValueCollection();
        //                    param.Add("key", "50d7cec1c380ecf610b6475acb9a148f");
        //                    param.Add("image", base64ImageRepresentation);
        //                    //делаем запрос методом POST и получем массив байтов
        //                    var response = client.UploadValues("https://api.imgbb.com/1/upload", "POST", param);
        //                    //декодируем
        //                    var jsonResponse = Encoding.Default.GetString(response);
        //                    //десериализуем
        //                    JsonDeser UploadedImageData = JsonConvert.DeserializeObject<JsonDeser>(jsonResponse);
        //                    //скопируем URL в буфер обмена
        //                    Clipboard.SetData(DataFormats.Text, (Object)UploadedImageData.data.image.url);
        //                    images.Add("url=" + '\u0022' + UploadedImageData.data.image.url + '\u0022');

        //                }

        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.Text == "jewelry")
            {
                lbTable.Text = "Драгоценности";
            }
            else if (cmbTables.Text == "pc")
            {
                lbTable.Text = "Настольный ПК";
            }
            else if(cmbTables.Text == "lap")
            {
                lbTable.Text = "Ноутбук";
            }
            else if (cmbTables.Text == "phone")
            {
                lbTable.Text = "Телефон";
            }
            else if (cmbTables.Text == "tool")
            {
                lbTable.Text = "Инструмент";
            }
            else
            {
                lbTable.Text = "Выберите значение";
            }
        }
    }
}
