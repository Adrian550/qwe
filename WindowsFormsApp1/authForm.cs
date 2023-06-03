using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Поля не заполнены!");
                return;
            }

            if (Auth.login(textBox1.Text, textBox2.Text))
            {
                cabinet cab_form = new cabinet();
                this.Hide();
                cab_form.Show();
            }
            else
            {
                MessageBox.Show("Пароль или логин не верный");
            }

        }
    }
}
