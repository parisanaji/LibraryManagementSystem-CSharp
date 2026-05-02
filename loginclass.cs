using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LibraryForm
{
    class loginclass
    {
        string username, password, user_type;
        public string setget_username
        {
            set { username = value; }
            get { return username; }
        }
        public string setget_password
        {
            set { password = value; }
            get { return password; }
 
        }
        public string setget_user_type
        {
            set { user_type = value; }
            get { return user_type; }
        }
        public DataTable login()
        {
            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter objdataadapter = new SqlDataAdapter("login",objconnection);
            objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objdataadapter.SelectCommand.Parameters.AddWithValue("@username",username);
            objdataadapter.SelectCommand.Parameters.AddWithValue("@password",password);
            DataTable dt=new DataTable();
            objdataadapter.Fill(dt);
            return dt;
        
        
        }
    }

}
