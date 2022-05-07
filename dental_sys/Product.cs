using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dental_sys;

public partial class Product : Form
{
    public Product()
    {
        InitializeComponent();
        
        DB db = new DB();
            
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
           
        
            MySqlCommand command = new MySqlCommand("select * from Memorie", db.getConnection());
                
                
            adapter.SelectCommand = command;
                
            adapter.Fill(table);
        
            
        guna2DataGridView1.DataSource = table;
        guna2DataGridView2.DataSource = table;
        guna2DataGridView3.DataSource = table;
        guna2DataGridView4.DataSource = table;

    }
}