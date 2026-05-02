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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void t1btdarj_Click_1(object sender, EventArgs e)
        {
            stuclass s = new stuclass();
            s.st_name=t1name.Text;
            s.st_family=t1family.Text;
            s.st_idnumber=t1shomareshenasname.Text;
            s.st_studentid = t1id.Text;
            s.st_fathername=t1fathername.Text;
            s.st_birthday=t1sal.Text+"/"+t1mah.Text+"/"+t1roz.Text;
            if(t1chbmojarad.Checked==true)
                s.st_vaziyatetaahol="مجرد";
            else
                s.st_vaziyatetaahol="متاهل";
            s.st_phonenumber=t1phonenumber.Text;
            s.st_education=t1cmbtahsilat.Text;
            if (t1rbzan.Checked==true)
                s.st_sex="زن";
            else
                s.st_sex="مرد";
            s.st_borrowedbook ="0";
            s.insert();
            t1name.Text = "";
            t1family.Text = "";
            t1shomareshenasname.Text = "";
            t1id.Text = "";
            t1fathername.Text = "";
            t1sal.Text = "";
            t1mah.Text = "";
            t1roz.Text = "";
          t1chbmojarad.Checked = false;
            t1phonenumber.Text = "";
            t1cmbtahsilat.Text = "";
            t1chbmotaahel.Checked = false;
            t1rbmard.Checked = false;
            t1rbzan.Checked = false;


        }

        private void t3btdarj_Click(object sender, EventArgs e)
        {
            bookclass b = new bookclass();
            b.bk_name = t3bname.Text;
            b.bk_code = t3bcod.Text;
            b.bk_writer = t3bmoalef.Text;
            b.bk_publisher = t3bnasher.Text;
            b.bk_numofprint = t3bnobatechap.Text;
            b.bk_tirajh = t3bnobatechap.Text;
            b.bk_subject = t3cmbmozo.Text;
            b.bk_shbak = t3bshabak.Text;
            b.bk_pubnumber = t3benteshrat.Text;
            b.bk_number = t3btedad.Text;
            b.insert();
            t3bcod.Text = "";
            t3benteshrat.Text = "";
            t3bmoalef.Text = "";
            t3bname.Text = "";
            t3bnasher.Text = "";
            t3bnobatechap.Text = "";
            t3bshabak.Text = "";
            t3cmbmozo.Text = "";
            t3btedad.Text = "";
            t3btirajh.Text = "";
                 

        }

        private void t2btsearch_Click(object sender, EventArgs e)
        {
            stuclass s = new stuclass();
            s.st_studentid = t2txtsearch.Text;
            DataTable dt = s.search_student_by_id();
            if (dt.Rows.Count == 0)
                MessageBox.Show("چنین دانشجویی وجود ندارد", "عدم وجود");
            else
            {
                panel_search_daneshjoo.Enabled = true;
                t2name.Text = dt.Rows[0]["stu_name"].ToString();
                t2family.Text = dt.Rows[0]["stu_family"].ToString();
                
                t2idnumber.Text = dt.Rows[0]["stu_idnumber"].ToString();
                t2fathername.Text = dt.Rows[0]["stu_fathername"].ToString();
                string[] a = dt.Rows[0]["stu_birthday"].ToString().Split('/');
                t2sal.Text = a[0];
                t2mah.Text = a[1];
                t2roz.Text = a[2];
                t2cmbeducation.Text = dt.Rows[0]["stu_education"].ToString();
                if (dt.Rows[0]["stu_sex"].ToString() == "زن")
                    t2rbzan.Checked = true;
                else
                    t2rbmard.Checked = true;
                if (dt.Rows[0]["stu_vaziyatetaahol"].ToString() == "مجرد")
                    t2chbmojarad.Checked = true;
                else
                    t2chbmoteaahel.Checked = true;
                t2phonenumber.Text = dt.Rows[0]["stu_phonenumber"].ToString();
            }
          

        }

        private void t4btsearch_Click(object sender, EventArgs e)

        {
            bookclass B = new bookclass();
            B.bk_code = t4txtsearch.Text;
            DataTable dt = B.search_book_by_bookcode();
            if (dt.Rows.Count == 0)
                MessageBox.Show("!چنین کتابی وجود ندارد", "عدم وجود");
            else
            {
                pannel_booksearch.Enabled = true;
                t4txtbookname.Text = dt.Rows[0]["book_name"].ToString();
                t4txtmoalef.Text = dt.Rows[0]["book_writer"].ToString();
                
                t4txtnasher.Text = dt.Rows[0]["book_publisher"].ToString();
                t4txtnobatechap.Text = dt.Rows[0]["book_numofprint"].ToString();
                t4txttirajh.Text = dt.Rows[0]["book_tirajh"].ToString();
                t4cmbbooksubject.Text = dt.Rows[0]["book_subject"].ToString();
                t4txtshabak.Text = dt.Rows[0]["book_shabak"].ToString();
                t4shomareentesharat.Text = dt.Rows[0]["book_pubnumber"].ToString();
                t4txttedad.Text = dt.Rows[0]["book_number"].ToString();
            }



        }

        private void t2bthazf_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            labelyear.Text = Convert.ToString(p.GetYear(DateTime.Now));
            labelmonth .Text = Convert.ToString(p.GetMonth(DateTime.Now));
            labelday.Text = Convert.ToString(p.GetDayOfMonth(DateTime.Now));
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tabControl1.Font = fontDialog1.Font;
               
                tabPage1.ForeColor = fontDialog1.Color;
                tabPage2.ForeColor = fontDialog1.Color;
                tabPage3.ForeColor = fontDialog1.Color;
                tabPage4.ForeColor = fontDialog1.Color;
                tabPage5.ForeColor = fontDialog1.Color;
                
               
               
                
                

                
            }
             
        }

        private void t2btvirayesh_Click(object sender, EventArgs e)
        {
            panel_search_daneshjoo.Enabled = false;
            stuclass s = new stuclass();
           s.st_studentid=t2txtsearch.Text;
            s.st_name = t2name.Text;
            s.st_family = t2family.Text;
            s.st_idnumber = t2idnumber.Text;
            
            s.st_fathername = t2fathername.Text;
            s.st_birthday = t2sal.Text + "/" + t2mah.Text + "/" + t2roz.Text;
            if (t2chbmojarad.Checked == true)
                s.st_vaziyatetaahol = "مجرد";
            else
                s.st_vaziyatetaahol = "متاهل";
            s.st_phonenumber = t2phonenumber.Text;
            s.st_education = t2cmbeducation.Text;
            if (t2rbzan.Checked == true)
                s.st_sex = "زن";
            else
                s.st_sex = "مرد";
            s.st_borrowedbook = "0";
            s.update_student();
            t2name.Text = "";
            t2family.Text = "";
            t2idnumber.Text = "";
            t2fathername.Text = "";
            t2sal.Text = "";
            t2mah.Text = "";
            t2roz.Text = "";
            t2cmbeducation.Text = "";
            t2phonenumber.Text = "";
            t2chbmoteaahel.Checked = false;
            t2chbmojarad.Checked = false;
            t2rbmard.Checked = false;
            t2rbzan.Checked = false;

        }
        private void t4btvirayesh_Click(object sender, EventArgs e)
        {
            pannel_booksearch.Enabled = false;
            bookclass b = new bookclass();
            b.bk_name = t4txtbookname.Text;
            b.bk_code = t4txtsearch.Text;
            b.bk_writer = t4txtmoalef.Text;
            b.bk_publisher = t4txtnasher.Text;
            b.bk_numofprint = t4txtnobatechap.Text;
            b.bk_tirajh = t4txttirajh.Text;
            b.bk_subject = t4cmbbooksubject.Text;
            b.bk_shbak = t4txtshabak.Text;
            b.bk_pubnumber = t4shomareentesharat.Text;
            b.bk_number = t4txttedad.Text;
            b.update_book();
            t4cmbbooksubject.Text = "";
            t4shomareentesharat.Text = "";
            t4txtbookname.Text = "";
            t4txtmoalef.Text = "";
            t4txtnasher.Text = "";
            t4txtnobatechap.Text = "";
            t4txtshabak.Text = "";
            t4txttedad.Text = "";
            t4txttirajh.Text = "";

        }
        private void t4bthazf_Click(object sender, EventArgs e)
        {
            pannel_booksearch.Enabled = false;
            bookclass b = new bookclass();
            b.bk_name = t4txtbookname.Text;
            b.bk_code = t4txtsearch.Text;
            b.bk_writer = t4txtmoalef.Text;
            b.bk_publisher = t4txtnasher.Text;
            b.bk_numofprint = t4txtnobatechap.Text;
            b.bk_tirajh = t4txttirajh.Text;
            b.bk_subject = t4cmbbooksubject.Text;
            b.bk_shbak = t4txtshabak.Text;
            b.bk_pubnumber = t4shomareentesharat.Text;
            b.bk_number = t4txttedad.Text;
            b.book_delete();
            t4cmbbooksubject.Text = "";
            t4shomareentesharat.Text = "";
            t4txtbookname.Text = "";
            t4txtmoalef.Text = "";
            t4txtnasher.Text = "";
            t4txtnobatechap.Text = "";
            t4txtshabak.Text = "";
            t4txttedad.Text = "";
            t4txttirajh.Text = "";


        }

        private void t2bthazzf_Click(object sender, EventArgs e)
        {
            panel_search_daneshjoo.Enabled = false;
            stuclass s = new stuclass();
            s.st_studentid = t2txtsearch.Text;
            s.st_name = t2name.Text;
            s.st_family = t2family.Text;
            s.st_idnumber = t2idnumber.Text;
            
            s.st_fathername = t2fathername.Text;
            s.st_birthday = t2sal.Text + "/" + t2mah.Text + "/" + t2roz.Text;
            if (t2chbmojarad.Checked == true)
                s.st_vaziyatetaahol = "مجرد";
            else
                s.st_vaziyatetaahol = "متاهل";
            s.st_phonenumber = t2phonenumber.Text;
            s.st_education = t2cmbeducation.Text;
            if (t2rbzan.Checked == true)
                s.st_sex = "زن";
            else
                s.st_sex = "مرد";
            s.st_borrowedbook = "0";
            s.student_delete();
            t2name.Text = "";
            t2family.Text = "";
            t2idnumber.Text = "";
            t2fathername.Text = "";
            t2sal.Text = "";
            t2mah.Text = "";
            t2roz.Text = "";
            t2cmbeducation.Text = "";
            t2phonenumber.Text = "";
            t2chbmoteaahel.Checked = false;
            t2chbmojarad.Checked = false;
            t2rbmard.Checked = false;
            t2rbzan.Checked = false;

        }



       

        

    

      
        
        }
    }

