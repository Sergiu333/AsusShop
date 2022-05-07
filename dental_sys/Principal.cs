using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dental_sys
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_val.Text = "Patients List";
            guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Patient());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label_val.Text = "Add news products";
            guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            container(new AddPc());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            // String sherchGame = Sherach.Text;
            // DB db = new DB();
            //
            // DataTable table = new DataTable();
            //
            // MySqlDataAdapter adapter = new MySqlDataAdapter();
            // MySqlCommand command = new MySqlCommand("select * from game where gen=@g", db.getConnection());
            // command.Parameters.Add("@g", MySqlDbType.VarChar).Value = sherchGame;
            // adapter.SelectCommand = command;
            // adapter.Fill(table);
            //
            // guna2DataGridView1.DataSource = table;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
