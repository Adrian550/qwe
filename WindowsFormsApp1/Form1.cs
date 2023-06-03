using Microsoft.Extensions.Logging;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddListItem(string name, Image photo, DateTime date)
        {
            var pictureBox = new PictureBox
            {
                Image = photo,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 100,
                Height = 100,
                Location = new Point(0, 0)
            };

            var nameLabel = new Label
            {
                Text = name,
                Location = new Point(100, 0),
                AutoSize = true,
            };


            var dateLabel = new Label
            {
                Text = date.ToString("dd.MM.yyyy"),
                Location = new Point(100, 44)
            };

            var container = new Panel
            {
                Controls = { pictureBox, nameLabel, dateLabel },
                Width = 800,
                Height = 120
            };

            flowLayoutPanel1.Controls.Add(container);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable result = database.Database.ExecuteQuery("SELECT * FROM events");

            foreach (DataRow row in result.Rows)
            {
                string name = row["name"].ToString();
                string path_image = "image\\events\\" + row["photo"];
                Image photo = Image.FromFile(path_image);
                DateTime date = DateTime.Parse(row["dateStart"].ToString());

                AddListItem(name, photo, date);
            }
        }

        private void authbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            authForm form = new authForm();
            form.Show();
        }
    }
}
