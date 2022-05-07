using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dental_sys;

public partial class AddPc : Form
{
    public AddPc()
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
    }

   

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        DB db = new DB();
        DataTable table = new DataTable();
            
        MySqlDataAdapter adapter = new MySqlDataAdapter();        
        MySqlCommand command = new MySqlCommand("INSERT INTO `asus_store`.`PC` (`id_Pc`, `nume`, `model`, `color`, `pret`, `data_fabricarii`, `material`, `stoc`, `id_Caracteristici`) VALUES('"+id.Text+"','"+insert1.Text+"','"+insert2.Text+"','"+insert3.Text+"','"+insert4.Text+"','"+insert5.Text+"','"+insert6.Text+"','"+insert7.Text+"','"+insert8.Text+"');", db.getConnection());
        adapter.SelectCommand = command;
        adapter.Fill(table);

        // insert1.Text = "";
        // insert2.Text = "";
        // insert3.Text = "";
        // insert4.Text = "";
        // insert5.Text = "";
        // insert6.Text = "";
        // insert7.Text = "";
        // insert8.Text = "";
        // insertid.Text = "";
        notification.Text = "A new product has been successfully added";
    }
}