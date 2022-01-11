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
        string cs = @"URI=file:Templates.db";
        public EdAddTemplate()
        {
            InitializeComponent();
            tbTitleApp.MaxLength = 54;
            tbTitle.MaxLength = 54;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTables.Text == "")
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
                    con.Close();
                    MessageBox.Show("Шаблон добавлен");
                    this.Close();
                }
            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
        }
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
