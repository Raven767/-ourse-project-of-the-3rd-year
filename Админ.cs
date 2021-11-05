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
    public partial class Админ : Form
    {
        string str = "server = localhost; user = root; password = sRHT8kXx; database = smd_lab1_ind; port = 3306";
        int help = 0;
        public Админ()
        {
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
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            textBox11.Hide();
        }
        public void Clear()
        {
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
        }
        public void Hidee()
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            textBox11.Hide();
        }
        public void Showe()
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox8.Show();
            textBox9.Show();
            textBox10.Show();
            textBox11.Show();
        }
        private void Админ_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                comboBox2.Items.Add(dataGridView1.Columns[j].HeaderText);
            }
        }
        private void Админ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Вход go = new Вход();
            go.Show();
            this.Hide();
        }
        public void updateTable()
        {
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "Select *  From smd_lab1_ind.`"+ comboBox1.Text + "`;";
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
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(str);
            textBox12.Clear();
            comboBox2.Items.Clear();
            if (comboBox1.Text == "заказы")
            {
                help = 2;
                Showe();
                Clear();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
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
                Showe();
                Clear();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
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
                Hidee();
                Clear();
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
                Hidee();
                Clear();
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
                Hidee();
                Clear();
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
                Hidee();
                Clear();
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
            if (comboBox1.Text == "адреса")
            {
                help = 8;
                Hidee();
                Clear();
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.адреса;";
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
            if (comboBox1.Text == "должности")
            {
                help = 9;
                Hidee();
                Clear();
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.должности;";
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
            if (comboBox1.Text == "заказчики")
            {
                help = 10;
                Hidee();
                Clear();
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.заказчики;";
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
            if (comboBox1.Text == "список")
            {
                help = 11;
                Hidee();
                Clear();
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.список;";
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
            if (comboBox1.Text == "страна производителя")
            {
                help = 12;
                Hidee();
                Clear();
                try
                {
                    connection.Open();
                    string sql = "Select *  From smd_lab1_ind.`страна производителя`;";
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
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                comboBox2.Items.Add(dataGridView1.Columns[j].HeaderText);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (help == 0)
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
                if (help == 2)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    {
                        textBox1.Text = row.Cells["Дата заказа"].Value.ToString();
                        textBox2.Text = row.Cells["Дата исполнения"].Value.ToString();
                        textBox3.Text = row.Cells["Код_заказчика"].Value.ToString();
                        //textBox4.Text = row.Cells["Доля предоплаты"].Value.ToString();
                        //textBox5.Text = row.Cells["Отметка об оплате"].Value.ToString();
                        //textBox6.Text = row.Cells["Отметка об исполнении"].Value.ToString();
                        textBox7.Text = row.Cells["Общая стоимость"].Value.ToString();
                        textBox8.Text = row.Cells["Срок общей гарантии"].Value.ToString();
                        textBox9.Text = row.Cells["Код сотрудника"].Value.ToString();
                        textBox10.Text = row.Cells["Код заказа"].Value.ToString();
                        textBox11.Text = row.Cells["idЗаявления"].Value.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (help == 0)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("Delete from сотрудники where КодСотрудника = '" + textBox1.Text + "';", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Clear();
                            updateTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            if (help == 2)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("Delete from заказы Where Код_заказчика ='" + textBox3.Text + "';",connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Clear();
                            updateTable();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (help == 2)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO smd_lab1_ind.заказы (`Дата заказа` , `Дата исполнения`, Код_заказчика  ,`Общая стоимость` ,`Сорк общей гарантии` ,`Код сотрудника`,`Код заказа`, idЗаявления) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Clear();
                            updateTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            if (help == 0)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO smd_lab1_ind.сотрудники (КодСотрудника , Имя ,Фамилия ,Отчество ,`Дата Рождения` ,Пол ,Адрес ,Телефон ,`Паспотрные данные`,`Код должности`, Код_Адреса,Iduser) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "',null)", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Clear();
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (help == 0)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE сотрудники SET КодСотрудника = '" + textBox1.Text + "', Имя = '" + textBox2.Text + "',Фамилия = '" + textBox3.Text + "',Отчество = '" + textBox4.Text + "',`Дата Рождения` = '" + textBox5.Text + "',Пол = '" + textBox6.Text + "',Адрес = '" + textBox7.Text + "',Телефон = '" + textBox8.Text + "',`Паспотрные данные` = '" + textBox9.Text + "',`Код должности` = '" + textBox10.Text + "', Код_Адреса= '" + textBox11.Text + "',Iduser=null Where КодСотрудника='" + textBox1.Text + "'", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Clear();
                            updateTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            if (help == 2)
            {
                MySqlConnection connection = new MySqlConnection(str);
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE заказы SET `Дата заказа`= '" + textBox1.Text + "' , `Дата исполнения`= '" + textBox2.Text + "', Код_заказчика = '" + textBox3.Text + "',`Общая стоимость`= '" + textBox7.Text + "' ,`Срок общей гарантии`= '" + textBox8.Text + "' ,`Код сотрудника`= '" + textBox9.Text + "',`Код заказа`= '" + textBox10.Text + "', idЗаявления= '" + textBox11.Text + "' Where `Дата заказа`= '" + textBox1.Text + "'", connection);
                    {
                        connection.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Clear();
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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(str);
                string cmd = "Select * FROM `"+ comboBox1.SelectedItem.ToString() +"` where (`"+ comboBox2.SelectedItem.ToString() + "` like '"+ textBox12.Text +"%');";
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Нет данных в таблице ","Ошибка поиска",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}