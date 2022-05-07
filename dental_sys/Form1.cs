using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace dental_sys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            
            String loginUser = guna2TextBox1.Text;
            String passUser = guna2TextBox2.Text;
            
            DB db = new DB();
            DataTable table = new DataTable();
            
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from users where name_ = @uL and lastName_ = @uP", db.getConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {
                Loading _load = new Loading();
                _load.Show();
            }
            else MessageBox.Show("Incorect password or login");
         
        }

            

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
      
    }
}
