namespace LibraryForm
{
    partial class Login
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
            this.btvorod = new System.Windows.Forms.Button();
            this.btkhoroj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_txtrname = new System.Windows.Forms.TextBox();
            this.Login_txtramz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btvorod
            // 
            this.btvorod.Location = new System.Drawing.Point(197, 322);
            this.btvorod.Name = "btvorod";
            this.btvorod.Size = new System.Drawing.Size(75, 23);
            this.btvorod.TabIndex = 0;
            this.btvorod.Text = "ورود";
            this.btvorod.UseVisualStyleBackColor = true;
            this.btvorod.Click += new System.EventHandler(this.btvorod_Click);
            // 
            // btkhoroj
            // 
            this.btkhoroj.Location = new System.Drawing.Point(351, 322);
            this.btkhoroj.Name = "btkhoroj";
            this.btkhoroj.Size = new System.Drawing.Size(75, 23);
            this.btkhoroj.TabIndex = 1;
            this.btkhoroj.Text = "خروج";
            this.btkhoroj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "رمز ورود";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کاربری";
            // 
            // Login_txtrname
            // 
            this.Login_txtrname.Location = new System.Drawing.Point(254, 58);
            this.Login_txtrname.Name = "Login_txtrname";
            this.Login_txtrname.Size = new System.Drawing.Size(100, 20);
            this.Login_txtrname.TabIndex = 4;
            // 
            // Login_txtramz
            // 
            this.Login_txtramz.Location = new System.Drawing.Point(254, 125);
            this.Login_txtramz.Name = "Login_txtramz";
            this.Login_txtramz.Size = new System.Drawing.Size(100, 20);
            this.Login_txtramz.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryForm.Properties.Resources._15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 427);
            this.Controls.Add(this.Login_txtramz);
            this.Controls.Add(this.Login_txtrname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btkhoroj);
            this.Controls.Add(this.btvorod);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvorod;
        private System.Windows.Forms.Button btkhoroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_txtrname;
        private System.Windows.Forms.TextBox Login_txtramz;
    }
}