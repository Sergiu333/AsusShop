using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace dental_sys
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            string myConnection = "server=localhost ; port=3306; username=root; password=Mama4ika12345; database=Asus_Store;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT max(id_Pc) FROM PC";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    label6.Text = myReader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
           
            
            
            // DB db = new DB();
            //
            // DataTable table = new DataTable();
            //
            // MySqlDataAdapter adapter = new MySqlDataAdapter();
            // MySqlCommand command = new MySqlCommand("SELECT max(id_Pc) FROM PC", db.getConnection());
            // adapter.SelectCommand = command;
            // adapter.Fill(table);
            //
            // // label4= 

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            
            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select * from PC", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            
            guna2DataGridView1.DataSource = table;
            ///////////////////////////////////////// guna2DataGridView1

            // int n = 4;
            // guna2DataGridView1.Rows.Add(n);
            // for (int i = 0; i < n; i++)
            // {
            //     guna2DataGridView1.Rows[i].Cells[1].Value = Image.FromFile("photos\\1.png");
            //     // guna2DataGridView1.Rows[i].Cells[2].Value = "Dian Cooper";
            //     // guna2DataGridView1.Rows[i].Cells[3].Value = "(239)555-2020";
            //     // guna2DataGridView1.Rows[i].Cells[4].Value = "Cilacap";
            //     // guna2DataGridView1.Rows[i].Cells[5].Value = "Jan 21,2020 -13:30";
            //     // guna2DataGridView1.Rows[i].Cells[6].Value = "Jan 21,2020";
            //     // guna2DataGridView1.Rows[i].Cells[7].Value = "Jan 21,2020";
            // }
        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            String search = Search.Text;
            DB db = new DB();
            
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
           
            if (search!="")
            {
                MySqlCommand command = new MySqlCommand("select * from "+search+"", db.getConnection());
                
                
                adapter.SelectCommand = command;
                
                adapter.Fill(table);
            }
            // SELECT max(id_Pc) FROM PC
            
            guna2DataGridView1.DataSource = table;
            // string cat = "Bird";
            
            
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            int rowIndex= guna2DataGridView1.CurrentCell.RowIndex+1;
            // guna2DataGridView1.Rows.RemoveAt(rowIndex);
            
            string myConnection = "server=localhost ; port=3306; username=root; password=Mama4ika12345; database=Asus_Store;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "delete from PC where id_Pc ="+rowIndex+"";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    label1.Text = myReader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
            DataTable table = new DataTable();
            MessageBox.Show("Row: "+rowIndex+" deleted");
            
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
         
        }
    }
}
