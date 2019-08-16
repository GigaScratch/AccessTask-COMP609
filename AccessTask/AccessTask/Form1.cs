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
        String conn_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\james\source\repos\GigaScratch\AccessTask-COMP609\AccessTask\AccessTask\FarmInfomation.accdb;Persist Security Info=False;";       //assigning engine and path 
        String err_msg = ''; 
        OleDbConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            query();   
            
        }

        private void query()
        {
            string q;
            string qu;
            try
            {
                q = "SELECT * FROM " + tb_name.Text;                    //writing in query data to be completed by user input
                OleDbCommand cmd = new OleDbCommand(q, conn);

                OleDbDataAdapter a = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                a.SelectCommand = cmd;
                a.Fill(dt);                                 //filling data table with query results
                dtb_table.DataSource = dt;                  //displaying data table on GUI

                qu = "SELECT * FROM " + tb_name.Text + " WHERE ID  = " + tb_id.Text;


                OleDbCommand cmd2 = new OleDbCommand(qu, conn);
                OleDbDataAdapter b = new OleDbDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                b.SelectCommand = cmd2;
                b.Fill(dt2);
                dtb_id.DataSource = dt2;

            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
}

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(conn_string);            //Connecting to ACCDB database
                conn.Open();
            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
        }

        private void Tb_name_TextChanged(object sender, EventArgs e)
        {
            tb_id.Enabled = true;
            btn_search.Enabled = true;                      //Enabling buttons once input is finished
        }
    }
}
