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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }
        string str = "server = localhost; user = root; password = sRHT8kXx; database = smd_lab1_ind; port = 3306";
        static string log;
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(str);
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox9.Text == ""))
            {
                MessageBox.Show(
                    "Вы ввели не все данные",
                    "Сообщение",
                    MessageBoxButtons.OK);
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show(
                    "Пароли не совпадают",
                    "Сообщение",
                    MessageBoxButtons.OK);
            }
            connection.Open();
            MySqlCommand hash = new MySqlCommand("call smd_lab1_ind.hashPass('"+ textBox2.Text +"')", connection);
            object hashPass = hash.ExecuteScalar();
            MySqlCommand opp = new MySqlCommand("INSERT INTO smd_lab1_ind.список (Логин, Пароль, Права) values('" + textBox1.Text + "','" + hashPass.ToString() + "','2')", connection);
            object result = opp.ExecuteScalar();
            string sql = "select id from список where (Логин ='" + textBox1.Text + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            object r = command.ExecuteScalar();
            MySqlCommand opp1 = new MySqlCommand("INSERT INTO smd_lab1_ind.заказчики (`Код заказчика`,Фамилия, Имя, Отчество, Адрес, Телефон, Iduser) values(null,'" + textBox5.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox9.Text + "', '"+r.ToString()+"')", connection);
            object result1 = opp1.ExecuteScalar();
            if ((result == null) && (result1 == null))
            {
                MessageBox.Show(
                   "Вы зарегестрировались",
                   "Сообщение",
                   MessageBoxButtons.OK);
                Вход go = new Вход();
                go.Show();
                this.Hide();
            }
            connection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Регистрация_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
