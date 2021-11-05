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
    public partial class Вход : Form
    {
        string str = "server = localhost; user = root; password = sRHT8kXx; database = smd_lab1_ind; port = 3306";
        
        public Вход()
        {
            InitializeComponent();
            button1.Visible = false;
            button3.Visible = false;
            if (checkBox1.Checked == false)
            {
                Parol.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //объявление глобальных переменных между форм
        static public string lines1;
        static public string lines2;
        private void button1_Click(object sender, EventArgs e)
        { 
            MySqlConnection connection = new MySqlConnection(str);
            lines1 = Login.Text;
            lines2 = Parol.Text;
            if ((Login.Text == "") || (Parol.Text == ""))   
            {
                MessageBox.Show(
                    "Вы ввели не все данные",
                    "Сообщение",
                    MessageBoxButtons.OK);
            }
            connection.Open();
            MySqlCommand hash = new MySqlCommand("call smd_lab1_ind.hashPass('" + lines2 + "')", connection);
            object hashPass = hash.ExecuteScalar();
            MySqlCommand cmd1 = new MySqlCommand(@"Select права from список where Логин=@log and Пароль=@hashPass", connection);
            string log = Login.Text;
            cmd1.Parameters.AddWithValue("@hashPass", hashPass);
            cmd1.Parameters.AddWithValue("@log", log);
            object result = cmd1.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show(
                    "Неверный логин или пароль",
                    "Сообщение",
                    MessageBoxButtons.OK);
            }
            if (result != null)
            {
                if (result.ToString() =="1")
                {
                    Админ admin = new Админ();
                    admin.Show();
                    this.Hide();
                }
                if (result.ToString() == "3")
                {
                    Продавец selller = new Продавец();
                    selller.Show();
                    this.Hide();
                }
                if (result.ToString() == "2")
                {
                    Пользователь user = new Пользователь();
                    user.Show();
                    this.Hide();
                }
            }
        }
        private void Окно_регистрации_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Админ")
            {
                button1.Visible = true;
            }
            if (comboBox1.Text == "Продавец")
            {
                button1.Visible = true;
            }
            if (comboBox1.Text == "Пользователь")
            {
                button1.Visible = true; 
                button3.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Регистрация reg = new Регистрация();
            reg.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Parol.PasswordChar = default;
            }
            if (checkBox1.Checked == false)
            {
                Parol.PasswordChar = '*';
            }
        }
    }
}
