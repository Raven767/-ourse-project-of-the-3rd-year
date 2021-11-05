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
    public partial class Продавец : Form
    {
        static public string str = "server = localhost; user = root; password = sRHT8kXx; database = smd_lab1_ind; port = 3306";
        //MySqlConnection connection = new MySqlConnection(str);
        int help = 0;
        public Продавец()
        {
            help = 1;

            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "Select *  From smd_lab1_ind.сотрудники;";
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
        
        public void updateTable()
        {
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "Select *  From smd_lab1_ind.сотрудники;";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(str);
            if (comboBox1.Text == "заказы")
            {
                help = 2;
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.заказы;";
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
            if (comboBox1.Text == "сотрудники")
            {
                help = 0;
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.сотрудники;";
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
            if (comboBox1.Text == "виды комплектующих")
            {
                help = 4;
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
            if (comboBox1.Text == "детали заказа")
            {
                help = 5;
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.`детали заказа`;";
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
            if (comboBox1.Text == "заявление")
            {
                help = 6;
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.заявление;";
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
            if (comboBox1.Text == "комплектующие")
            {
                help = 7;
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
        }

        private void Продавец_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вход go = new Вход();
            go.Show();
            this.Hide();
        }

        private void Продавец_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (help == 0)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE сотрудники SET КодСотрудника = '" + textBox1.Text + "', Имя = '" + textBox2.Text + "',Фамилия = '" + textBox3.Text + "',Отчество = '" + textBox4.Text + "',`Дата Рождения` = '" + textBox5.Text + "',Пол = '" + textBox6.Text + "',Адрес = '" + textBox7.Text + "',Телефон = '" + textBox8.Text + "',`Паспотрные данные` = '" + textBox9.Text + "',`Код должности` = '" + textBox10.Text + "', Код_Адреса= '" + textBox11.Text + "' Where КодСотрудника='" + textBox1.Text + "'", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            textBox10.Clear();
                            textBox11.Clear();
                            updateTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                {
                    textBox1.Text = row.Cells["КодСотрудника"].Value.ToString();
                    textBox2.Text = row.Cells["Имя"].Value.ToString();
                    textBox3.Text = row.Cells["Фамилия"].Value.ToString();
                    textBox4.Text = row.Cells["Отчество"].Value.ToString();
                    textBox5.Text = row.Cells["Дата Рождения"].Value.ToString();
                    textBox6.Text = row.Cells["Пол"].Value.ToString();
                    textBox7.Text = row.Cells["Адрес"].Value.ToString();
                    textBox8.Text = row.Cells["Телефон"].Value.ToString();
                    textBox9.Text = row.Cells["Паспотрные данные"].Value.ToString();
                    textBox10.Text = row.Cells["Код должности"].Value.ToString();
                    textBox11.Text = row.Cells["Код_Адреса"].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (help == 0)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("Delete from сотрудники where КодСотрудника = '" + textBox1.Text + "' and Имя = '" + textBox2.Text + "'and Фамилия = '" + textBox3.Text + "' and Отчество = '" + textBox4.Text + "'and `Дата Рождения` = '" + textBox5.Text + "'and Пол = '" + textBox6.Text + "'and Адрес = '" + textBox7.Text + "'and Телефон = '" + textBox8.Text + "' and `Паспотрные данные` = '" + textBox9.Text + "' and `Код должности` = '" + textBox10.Text + "' and  Код_Адреса = '" + textBox11.Text + "'", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            textBox10.Clear();
                            textBox11.Clear();
                            updateTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (help == 0)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO smd_lab1_ind.сотрудники (КодСотрудника , Имя ,Фамилия ,Отчество ,`Дата Рождения` ,Пол ,Адрес ,Телефон ,`Паспотрные данные`,`Код должности`, Код_Адреса) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            textBox10.Clear();
                            textBox11.Clear();
                            updateTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }
    }
}