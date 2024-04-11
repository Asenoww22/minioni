using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minioni
{
    public partial class Form1 : Form
    {
        String connection = " server = 10.42.42.64;port=3306;" +
            "user=PC1;" +
            "password=1111;" +
            "database=minions";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection dbMinions = new MySqlConnection(connection );
            dbMinions.Open();
            MessageBox.Show("connection is one open");
            MySqlCommand command = new MySqlCommand(
                "select * from towns",dbMinions);
            MySqlDataReader reader = command.ExecuteReader();

            List<ComboItem> lists = new List<ComboItem>();
            while (reader.Read())
            {
                ComboItem item = new ComboItem();
                item.Id = (int)reader[0];
                item.Name = (string)reader[1];

                lists.Add(item);    
            }

            reader.Close();

           comboBox1.DataSource = lists; 
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            dbMinions.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" 105.  ti vuvede {textBox1.Text}");
            $"s godini{textBox2.Text}string grad" +
                $"{comboBox1.Text}-- > {comboBox1.SelectedValue}"); 
        }


        string insertSQL = "INSERT INTO  minions.minions" +
            "(id,'name',age,town_id)" +
            $"VALUES (105,@townName,@Age,@townid)";
        //zapochva insert query
        // query.Parameters.AddWichValue("@townname"











        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
