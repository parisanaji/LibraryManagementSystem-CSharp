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
    public partial class search : Form
    {
        private string stdcode_sarasari;
        public search()
        {
            InitializeComponent();
        }
        public search(string stdcode)
        {
            InitializeComponent();
            stdcode_sarasari=stdcode;
        }

        private void btsearch_formsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            bookclass b = new bookclass();
            b.bk_name = txtbooknamefsearch.Text;
            b.bk_publisher = txtmoalef_formsearch.Text;
            DataSet ds = b.search_datagridview();
            
            dataGridView1.DataSource=ds.Tables["tbl_book"];
            dataGridView1.AutoGenerateColumns = true;
        }

       // private void search_Load(object sender, EventArgs e)
       // {
          //  stuclass s = new stuclass();
          //  s.stu_idnumber = stdcode_sarasari;

       // }
    }
}
