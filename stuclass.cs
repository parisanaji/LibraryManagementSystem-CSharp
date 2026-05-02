using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LibraryForm
{
    class stuclass
    {
        string student_name = "", student_family = "",
              student_idnumber = "", student_fathername = "", student_birthday = "",
              student_vaziyatetaahol = "", student_phonenumber = "", student_education = "",
              student_sex = "", student_studentid = "", student_borrowedbook = "";
        public string st_name
        {
            set { student_name = value; }

            get { return student_name; }
        }
        public string st_family
        {
            set { student_family = value; }

            get { return student_family; }
        }

        public string st_idnumber
        {
            set { student_idnumber = value; }
            get { return student_idnumber; }
        }


        public string st_fathername
        {

            set { student_fathername = value; }

            get { return student_fathername; }
        }
        public string st_birthday
        {
            set { student_birthday = value; }

            get { return student_birthday; }
        }
        public string st_vaziyatetaahol
        {
            set { student_vaziyatetaahol = value; }

            get { return student_vaziyatetaahol; }
        }
        public string st_phonenumber
        {
            set { student_phonenumber = value; }

            get { return student_phonenumber; }
        }
        public string st_education
        {
            set { student_education = value; }

            get { return student_education; }
        }
        public string st_sex
        {
            set { student_sex = value; }
            get { return student_sex; }
        }
        public string st_studentid
        {
            set { student_studentid = value; }
            get { return student_studentid; }
        }
        public string st_borrowedbook
        {
            set { student_borrowedbook = value; }
            get { return student_borrowedbook; }
        }

        public void insert()
        {

            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlCommand objcammand = new SqlCommand("insert_student", objconnection);
            objcammand.CommandType = CommandType.StoredProcedure;
            objcammand.Parameters.AddWithValue("@stu_name", student_name);
            objcammand.Parameters.AddWithValue("@stu_family", student_family);
            objcammand.Parameters.AddWithValue("@stu_idnumber", student_idnumber);
            objcammand.Parameters.AddWithValue("@stu_fathername", student_fathername);
            objcammand.Parameters.AddWithValue("@stu_birthday", student_birthday);
            objcammand.Parameters.AddWithValue("@stu_vaziyatetaahol", student_vaziyatetaahol);
            objcammand.Parameters.AddWithValue("@stu_phonenumber", student_phonenumber);
            objcammand.Parameters.AddWithValue("@stu_education", student_education);
            objcammand.Parameters.AddWithValue("@stu_sex", student_sex);
            objcammand.Parameters.AddWithValue("@stu_studentid", student_studentid);
            objcammand.Parameters.AddWithValue("@stu_borrowedbook", student_borrowedbook);
            try
            {
                objconnection.Open();
                objcammand.ExecuteNonQuery();
                objconnection.Close();
                MessageBox.Show("درج دانشجو با موفقیت انجام شد", "درج", MessageBoxButtons.OK);
            }
            catch (SqlException ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }


        }

        public DataTable search_student_by_id()
        {
            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter objDataAdapter = new SqlDataAdapter("search_student_by_id", objconnection);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objDataAdapter.SelectCommand.Parameters.AddWithValue("@stu_studentid", student_studentid);
            DataTable dt = new DataTable();
            objDataAdapter.Fill(dt);
            return dt;
        }
        public void update_student()
        {
            

                SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
                SqlCommand objcammand = new SqlCommand("update_student", objconnection);
                objcammand.CommandType = CommandType.StoredProcedure;
                objcammand.Parameters.AddWithValue("@stu_name", student_name);
                objcammand.Parameters.AddWithValue("@stu_family", student_family);
                objcammand.Parameters.AddWithValue("@stu_idnumber", student_idnumber);
                objcammand.Parameters.AddWithValue("@stu_fathername", student_fathername);
                objcammand.Parameters.AddWithValue("@stu_birthday", student_birthday);
                objcammand.Parameters.AddWithValue("@stu_vaziyatetaahol", student_vaziyatetaahol);
                objcammand.Parameters.AddWithValue("@stu_phonenumber", student_phonenumber);
                objcammand.Parameters.AddWithValue("@stu_education", student_education);
                objcammand.Parameters.AddWithValue("@stu_sex", student_sex);
                objcammand.Parameters.AddWithValue("@stu_studentid", student_studentid);
                objcammand.Parameters.AddWithValue("@stu_borrowedbook", student_borrowedbook);
                try
                { 
                    objconnection.Open();
                    objcammand.ExecuteNonQuery();
                    objconnection.Close();
                    MessageBox.Show("ویرایش دانشجو با موفقیت انجام شد", "ویرایش", MessageBoxButtons.OK);
                }
                catch (SqlException ERROR)
                {
                    MessageBox.Show(ERROR.Message);
                }


            
        
        }
        public void student_delete()
        {
            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlCommand objcommand = new SqlCommand("student_delete", objconnection);
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.Parameters.AddWithValue("@stu_name",student_name);
            objcommand.Parameters.AddWithValue("@stu_family",student_family );
            objcommand.Parameters.AddWithValue("@stu_idnumber", student_idnumber);
            objcommand.Parameters.AddWithValue("@stu_fathername",student_fathername );
            objcommand.Parameters.AddWithValue("@stu_birthday",student_birthday);
            objcommand.Parameters.AddWithValue("@stu_vaziyatetaahol", student_vaziyatetaahol);
            objcommand.Parameters.AddWithValue("@stu_phonenumber", student_phonenumber);
            objcommand.Parameters.AddWithValue("@stu_education", student_education);
            objcommand.Parameters.AddWithValue("@stu_sex", student_sex);
            objcommand.Parameters.AddWithValue("@stu_studentid", student_studentid);
            objcommand.Parameters.AddWithValue("@stu_borrowedbook", student_borrowedbook);
            try
            {
                objconnection.Open();
                objcommand.ExecuteNonQuery();
                objconnection.Close();
                MessageBox.Show("حذف دانشجو با موفقیت انجام شد", "حذف", MessageBoxButtons.OK);
            }
            catch (SqlException ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }

        
        
        
        
        }
    }
}
