
namespace VeriTabanıÇalışması
{
    partial class Form1
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
            this.grid_veri = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ad_soyad = new System.Windows.Forms.TextBox();
            this.textBox_tc_kimlik = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_password_update = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_tc_kimlik_update = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ad_soyad_update = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_veri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_veri
            // 
            this.grid_veri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_veri.Location = new System.Drawing.Point(64, 42);
            this.grid_veri.Name = "grid_veri";
            this.grid_veri.Size = new System.Drawing.Size(569, 271);
            this.grid_veri.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad ve Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre :";
            // 
            // textBox_ad_soyad
            // 
            this.textBox_ad_soyad.Location = new System.Drawing.Point(97, 35);
            this.textBox_ad_soyad.Name = "textBox_ad_soyad";
            this.textBox_ad_soyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_ad_soyad.TabIndex = 5;
            // 
            // textBox_tc_kimlik
            // 
            this.textBox_tc_kimlik.Location = new System.Drawing.Point(97, 72);
            this.textBox_tc_kimlik.Name = "textBox_tc_kimlik";
            this.textBox_tc_kimlik.Size = new System.Drawing.Size(100, 20);
            this.textBox_tc_kimlik.TabIndex = 6;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(97, 103);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_tc_kimlik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ad_soyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(64, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 187);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı ekleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_password_update);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.textBox_tc_kimlik_update);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_ad_soyad_update);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(402, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Şifre Güncelleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad ve Soyad :";
            // 
            // textBox_password_update
            // 
            this.textBox_password_update.Location = new System.Drawing.Point(97, 103);
            this.textBox_password_update.Name = "textBox_password_update";
            this.textBox_password_update.Size = new System.Drawing.Size(100, 20);
            this.textBox_password_update.TabIndex = 7;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(219, 67);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_tc_kimlik_update
            // 
            this.textBox_tc_kimlik_update.Location = new System.Drawing.Point(97, 72);
            this.textBox_tc_kimlik_update.Name = "textBox_tc_kimlik_update";
            this.textBox_tc_kimlik_update.Size = new System.Drawing.Size(100, 20);
            this.textBox_tc_kimlik_update.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // textBox_ad_soyad_update
            // 
            this.textBox_ad_soyad_update.Location = new System.Drawing.Point(97, 35);
            this.textBox_ad_soyad_update.Name = "textBox_ad_soyad_update";
            this.textBox_ad_soyad_update.Size = new System.Drawing.Size(100, 20);
            this.textBox_ad_soyad_update.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Şifre :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Silmek İstediğniz Kullanıcı ID \'sini giriniz :";
            // 
            // textBox_sil
            // 
            this.textBox_sil.Location = new System.Drawing.Point(499, 557);
            this.textBox_sil.Name = "textBox_sil";
            this.textBox_sil.Size = new System.Drawing.Size(100, 20);
            this.textBox_sil.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 607);
            this.Controls.Add(this.textBox_sil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_veri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_veri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_veri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ad_soyad;
        private System.Windows.Forms.TextBox textBox_tc_kimlik;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_password_update;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_tc_kimlik_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ad_soyad_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sil;
    }
}

