using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryForm
{
    class bookclass
    {
        string b_name = "", b_code = "", b_writer = "",
            b_publisher = "", b_numofprint = "", b_tirajh = "",
            b_subject = "", b_shabak = "", b_pubnumber = "", b_number = "";
        public string bk_name
        {
            set { b_name = value; }
            get { return b_name; }
        }
        public string bk_code
        {
            set { b_code = value; }
            get { return b_code; }
        }
        public string bk_writer
        {
            set { b_writer = value; }
            get { return b_writer; }
        }

        public string bk_publisher
        {
            set { b_publisher = value; }
            get { return b_publisher; }
        }

        public string bk_numofprint
        {
            set { b_numofprint = value; }
            get { return b_numofprint; }
        }

        public string bk_tirajh
        {
            set { b_tirajh = value; }
            get { return b_tirajh; }
        }
        public string bk_subject
        {
            set { b_subject = value; }
            get { return b_subject; }
        }


        public string bk_shbak
        {
            set { b_shabak = value; }
            get { return b_shabak; }
        }

        public string bk_pubnumber
        {
            set { b_pubnumber = value; }
            get { return b_pubnumber; }
        }
        public string bk_number
        {
            set { b_number = value; }
            get { return b_number; }
        }
        public void insert()
        {

            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlCommand objcammand = new SqlCommand("insert_book", objconnection);
            objcammand.CommandType = CommandType.StoredProcedure;
            objcammand.Parameters.AddWithValue("@book_name", b_name);
            objcammand.Parameters.AddWithValue("@book_code", b_code);
            objcammand.Parameters.AddWithValue("@book_writer", b_writer);
            objcammand.Parameters.AddWithValue("@book_publisher", b_publisher);
            objcammand.Parameters.AddWithValue("@book_numofprint", b_numofprint);
            objcammand.Parameters.AddWithValue("@book_tirajh", b_tirajh);
            objcammand.Parameters.AddWithValue("@book_subject", b_subject);
            objcammand.Parameters.AddWithValue("@book_shabak", b_shabak);
            objcammand.Parameters.AddWithValue("@book_pubnumber", b_pubnumber);
            objcammand.Parameters.AddWithValue("@book_number", b_number);
            try
            {
                objconnection.Open();
                objcammand.ExecuteNonQuery();
                objconnection.Close();
                MessageBox.Show("درج کتاب با موفقیت انجام شد", "درج", MessageBoxButtons.OK);
            }
            catch (SqlException ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }


        }
        public DataTable search_book_by_bookcode()
        {
            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter objDataAdapter = new SqlDataAdapter("search_book_by_bookcode", objconnection);
            objDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objDataAdapter.SelectCommand.Parameters.AddWithValue("@book_code", b_code);
            DataTable dt = new DataTable();
            objDataAdapter.Fill(dt);
            return dt;


        }
        public void book_delete()
        {
            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlCommand objcommand = new SqlCommand("book_delete", objconnection);
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.Parameters.AddWithValue("@book_name", b_name);
            objcommand.Parameters.AddWithValue("@book_code", b_code);
            objcommand.Parameters.AddWithValue("@book_writer", b_writer);
            objcommand.Parameters.AddWithValue("@book_publisher", b_publisher);
            objcommand.Parameters.AddWithValue("@book_numofprint", b_numofprint);
            objcommand.Parameters.AddWithValue("@book_tirajh", b_tirajh);
            objcommand.Parameters.AddWithValue("@book_subject", b_subject);
            objcommand.Parameters.AddWithValue("@book_shabak", b_shabak);
            objcommand.Parameters.AddWithValue("@book_pubnumber", b_pubnumber);
            objcommand.Parameters.AddWithValue("@book_number", b_number);
            try
            {
                objconnection.Open();
                objcommand.ExecuteNonQuery();
                objconnection.Close();
                MessageBox.Show("حذف کتاب با موفقیت انجام شد", "حذف", MessageBoxButtons.OK);
            }
            catch (SqlException ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }
        }
        public void update_book()
        {


            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            
            SqlCommand objcommand = new SqlCommand("update_book", objconnection);
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.Parameters.AddWithValue("@book_name", b_name);
            objcommand.Parameters.AddWithValue("@book_code", b_code);
            objcommand.Parameters.AddWithValue("@book_writer", b_writer);
            objcommand.Parameters.AddWithValue("@book_publisher", b_publisher);
            objcommand.Parameters.AddWithValue("@book_numofprint", b_numofprint);
            objcommand.Parameters.AddWithValue("@book_tirajh", b_tirajh);
            objcommand.Parameters.AddWithValue("@book_subject", b_subject);
            objcommand.Parameters.AddWithValue("@book_shabak", b_shabak);
            objcommand.Parameters.AddWithValue("@book_pubnumber", b_pubnumber);
            objcommand.Parameters.AddWithValue("@book_number", b_number);
            try
            {
                objconnection.Open();
                objcommand.ExecuteNonQuery();
                objconnection.Close();
                MessageBox.Show("ویرایش  کتاب با موفقیت انجام شد", "ویرایش", MessageBoxButtons.OK);
            }
            catch (SqlException ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }




        }
        public DataSet  search_datagridview()
        {
           
            SqlConnection objconnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\tbl_student.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter objdataadapter = new SqlDataAdapter("search_datagridview",objconnection);
            objdataadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objdataadapter.SelectCommand.Parameters.AddWithValue("@book_name",b_name);
            objdataadapter.SelectCommand.Parameters.AddWithValue("@book_publisher",b_publisher);
            DataSet ds = new DataSet();
            objdataadapter.Fill(ds,"tbl_book"); 
            return ds;
        }
        
    }
}