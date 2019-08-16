using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace AccessTask
{
    public partial class Form1 : Form
    {
        String conn_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\james\source\repos\GigaScratch\AccessTask-COMP609\AccessTask\AccessTask\FarmInfomation.accdb;Persist Security Info=False;";
        String q = "";
        String err_msg = ""; 
        OleDbConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void Data_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(conn_string);
                conn.Open();
            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
        }
    }
}
