namespace LibraryForm
{
    partial class search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btsearch_formsearch = new System.Windows.Forms.Button();
            this.txtbooknamefsearch = new System.Windows.Forms.TextBox();
            this.txtmoalef_formsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_studentDataSet = new LibraryForm.tbl_studentDataSet();
            this.tblbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_bookTableAdapter = new LibraryForm.tbl_studentDataSetTableAdapters.tbl_bookTableAdapter();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookwriterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknumofprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktirajhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookshabakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpubnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booknameDataGridViewTextBoxColumn,
            this.bookcodeDataGridViewTextBoxColumn,
            this.bookwriterDataGridViewTextBoxColumn,
            this.bookpublisherDataGridViewTextBoxColumn,
            this.booknumofprintDataGridViewTextBoxColumn,
            this.booktirajhDataGridViewTextBoxColumn,
            this.booksubjectDataGridViewTextBoxColumn,
            this.bookshabakDataGridViewTextBoxColumn,
            this.bookpubnumberDataGridViewTextBoxColumn,
            this.booknumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblbookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // btsearch_formsearch
            // 
            this.btsearch_formsearch.Location = new System.Drawing.Point(504, 43);
            this.btsearch_formsearch.Name = "btsearch_formsearch";
            this.btsearch_formsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch_formsearch.TabIndex = 1;
            this.btsearch_formsearch.Text = "جستجو";
            this.btsearch_formsearch.UseVisualStyleBackColor = true;
            this.btsearch_formsearch.Click += new System.EventHandler(this.btsearch_formsearch_Click);
            // 
            // txtbooknamefsearch
            // 
            this.txtbooknamefsearch.Location = new System.Drawing.Point(295, 46);
            this.txtbooknamefsearch.Name = "txtbooknamefsearch";
            this.txtbooknamefsearch.Size = new System.Drawing.Size(100, 20);
            this.txtbooknamefsearch.TabIndex = 2;
            // 
            // txtmoalef_formsearch
            // 
            this.txtmoalef_formsearch.Location = new System.Drawing.Point(295, 90);
            this.txtmoalef_formsearch.Name = "txtmoalef_formsearch";
            this.txtmoalef_formsearch.Size = new System.Drawing.Size(100, 20);
            this.txtmoalef_formsearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام کتاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "مولف کتاب";
            // 
            // tbl_studentDataSet
            // 
            this.tbl_studentDataSet.DataSetName = "tbl_studentDataSet";
            this.tbl_studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbookBindingSource
            // 
            this.tblbookBindingSource.DataMember = "tbl_book";
            this.tblbookBindingSource.DataSource = this.tbl_studentDataSet;
            // 
            // tbl_bookTableAdapter
            // 
            this.tbl_bookTableAdapter.ClearBeforeFill = true;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "نام کتاب";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // bookcodeDataGridViewTextBoxColumn
            // 
            this.bookcodeDataGridViewTextBoxColumn.DataPropertyName = "book_code";
            this.bookcodeDataGridViewTextBoxColumn.HeaderText = "کد کتاب";
            this.bookcodeDataGridViewTextBoxColumn.Name = "bookcodeDataGridViewTextBoxColumn";
            // 
            // bookwriterDataGridViewTextBoxColumn
            // 
            this.bookwriterDataGridViewTextBoxColumn.DataPropertyName = "book_writer";
            this.bookwriterDataGridViewTextBoxColumn.HeaderText = "مولف";
            this.bookwriterDataGridViewTextBoxColumn.Name = "bookwriterDataGridViewTextBoxColumn";
            // 
            // bookpublisherDataGridViewTextBoxColumn
            // 
            this.bookpublisherDataGridViewTextBoxColumn.DataPropertyName = "book_publisher";
            this.bookpublisherDataGridViewTextBoxColumn.HeaderText = "ناشر ";
            this.bookpublisherDataGridViewTextBoxColumn.Name = "bookpublisherDataGridViewTextBoxColumn";
            // 
            // booknumofprintDataGridViewTextBoxColumn
            // 
            this.booknumofprintDataGridViewTextBoxColumn.DataPropertyName = "book_numofprint";
            this.booknumofprintDataGridViewTextBoxColumn.HeaderText = "نوبت چاپ";
            this.booknumofprintDataGridViewTextBoxColumn.Name = "booknumofprintDataGridViewTextBoxColumn";
            // 
            // booktirajhDataGridViewTextBoxColumn
            // 
            this.booktirajhDataGridViewTextBoxColumn.DataPropertyName = "book_tirajh";
            this.booktirajhDataGridViewTextBoxColumn.HeaderText = "تیراژ";
            this.booktirajhDataGridViewTextBoxColumn.Name = "booktirajhDataGridViewTextBoxColumn";
            // 
            // booksubjectDataGridViewTextBoxColumn
            // 
            this.booksubjectDataGridViewTextBoxColumn.DataPropertyName = "book_subject";
            this.booksubjectDataGridViewTextBoxColumn.HeaderText = "موضوع کتاب";
            this.booksubjectDataGridViewTextBoxColumn.Name = "booksubjectDataGridViewTextBoxColumn";
            // 
            // bookshabakDataGridViewTextBoxColumn
            // 
            this.bookshabakDataGridViewTextBoxColumn.DataPropertyName = "book_shabak";
            this.bookshabakDataGridViewTextBoxColumn.HeaderText = "شابک";
            this.bookshabakDataGridViewTextBoxColumn.Name = "bookshabakDataGridViewTextBoxColumn";
            // 
            // bookpubnumberDataGridViewTextBoxColumn
            // 
            this.bookpubnumberDataGridViewTextBoxColumn.DataPropertyName = "book_pubnumber";
            this.bookpubnumberDataGridViewTextBoxColumn.HeaderText = "شماره انتشارات";
            this.bookpubnumberDataGridViewTextBoxColumn.Name = "bookpubnumberDataGridViewTextBoxColumn";
            // 
            // booknumberDataGridViewTextBoxColumn
            // 
            this.booknumberDataGridViewTextBoxColumn.DataPropertyName = "book_number";
            this.booknumberDataGridViewTextBoxColumn.HeaderText = "تعداد کتاب";
            this.booknumberDataGridViewTextBoxColumn.Name = "booknumberDataGridViewTextBoxColumn";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryForm.Properties.Resources._21;
            this.ClientSize = new System.Drawing.Size(768, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmoalef_formsearch);
            this.Controls.Add(this.txtbooknamefsearch);
            this.Controls.Add(this.btsearch_formsearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "search";
            this.Text = "search";
            //this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btsearch_formsearch;
        private System.Windows.Forms.TextBox txtbooknamefsearch;
        private System.Windows.Forms.TextBox txtmoalef_formsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private tbl_studentDataSet tbl_studentDataSet;
        private System.Windows.Forms.BindingSource tblbookBindingSource;
        private tbl_studentDataSetTableAdapters.tbl_bookTableAdapter tbl_bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookwriterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknumofprintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktirajhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookshabakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpubnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknumberDataGridViewTextBoxColumn;
    }
}