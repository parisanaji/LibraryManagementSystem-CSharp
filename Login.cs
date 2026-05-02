using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btvorod_Click(object sender, EventArgs e)
        {
            loginclass l =new loginclass() ;
            l.setget_username = Login_txtrname.Text;
            l.setget_password = Login_txtramz.Text;
            DataTable dt=l.login();
            if (dt.Rows.Count == 0)
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            else if (dt.Rows[0]["user_type"].ToString() == "student")
            {
                search s = new search();
                s.Show();
            }
            else if (dt.Rows[0]["user_type"].ToString() == "admin")
            {
                Admin A = new Admin();
                A.Show();
            }
        }
    }
}
