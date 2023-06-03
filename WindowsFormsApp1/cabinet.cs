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
    public partial class cabinet : Form
    {
        public cabinet()
        {
            InitializeComponent();
        }

        private void cabinet_Load(object sender, EventArgs e)
        {
            infoWindow.Text += " " + Auth.role + "а";
            profilePhoto.Image = Auth.photo;

            DateTime currentTime = DateTime.Now;
            string timeOfDay = (currentTime.Hour >= 9 && currentTime.Hour <= 11) ? "Доброе Утро" : (currentTime.Hour >= 11 && currentTime.Hour <= 18) ? "Добрый День" : "Добрый Вечер";

            joinHello.Text = timeOfDay;
            fullName.Text = "Mr." + Auth.name + " " + Auth.middleName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addModer form   = new addModer();
            form.ShowDialog();
        }
    }
}
