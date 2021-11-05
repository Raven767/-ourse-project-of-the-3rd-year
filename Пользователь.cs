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

namespace Курсач
{
    public partial class Пользователь : Form
    {
        static public string str = "server = localhost; user = root; password = sRHT8kXx; database = smd_lab1_ind; port = 3306";
        public Пользователь()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "Select *  From smd_lab1_ind.комплектующие;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вход go = new Вход();
            go.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(str);
            if (comboBox1.Text == "Комплектующие")
            {
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.комплектующие;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (comboBox1.Text == "Виды комплактующих")
            {
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.`виды комплектующих`;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Пользователь_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказы go = new Заказы();
            go.Show();
            this.Hide();
        }
    }
}
