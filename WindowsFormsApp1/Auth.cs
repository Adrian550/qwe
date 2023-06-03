using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static public class Auth
    {
        static public string role;
        static public Image photo;
        static public string name;
        static public string middleName;
        static public bool login(string IdNumber, string password)
        {
            DataTable result = database.Database.ExecuteQuery("SELECT * FROM users WHERE id = " + IdNumber + " and password = '" + password + "'");
            if (result.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                foreach (DataRow row in result.Rows)
                {
                    name = row["lastName"].ToString();
                    middleName = row["middleName"].ToString();
                    role = row["role"].ToString();
                    string path_image = "image\\users\\" + row["photo"];
                    photo = Image.FromFile(path_image);
                }
                return true;
            }
        }
    }
}
