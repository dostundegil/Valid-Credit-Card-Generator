
namespace Kredi_Kartı
{
    partial class frmCreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditCard));
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumara = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbllimit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblcvv = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.txtlimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtharca = new System.Windows.Forms.TextBox();
            this.lblborc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtborcode = new System.Windows.Forms.TextBox();
            this.borcode = new System.Windows.Forms.Button();
            this.puanileode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lbladd = new System.Windows.Forms.Label();
            this.lbldatee = new System.Windows.Forms.Label();
            this.lblkartnumara = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(313, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kart Oluştur";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "hand.png");
            this.imageList1.Images.SetKeyName(2, "money.png");
            this.imageList1.Images.SetKeyName(3, "save-money.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kart Sahibinin Adı ve Soyadını Giriniz";
            // 
            // lblnumara
            // 
            this.lblnumara.AutoSize = true;
            this.lblnumara.Location = new System.Drawing.Point(306, 77);
            this.lblnumara.Name = "lblnumara";
            this.lblnumara.Size = new System.Drawing.Size(0, 20);
            this.lblnumara.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kart Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart Limiti:";
            // 
            // lbllimit
            // 
            this.lbllimit.AutoSize = true;
            this.lbllimit.Location = new System.Drawing.Point(306, 108);
            this.lbllimit.Name = "lbllimit";
            this.lbllimit.Size = new System.Drawing.Size(0, 20);
            this.lbllimit.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kart Puanı:";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Location = new System.Drawing.Point(632, 46);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(0, 20);
            this.lblpuan.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "CVV:";
            // 
            // lblcvv
            // 
            this.lblcvv.AutoSize = true;
            this.lblcvv.Location = new System.Drawing.Point(632, 77);
            this.lblcvv.Name = "lblcvv";
            this.lblcvv.Size = new System.Drawing.Size(0, 20);
            this.lblcvv.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Son Kullanma Tarihi:";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(632, 108);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(0, 20);
            this.lbltarih.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kart Tipini Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Visa",
            "Master",
            "Amex"});
            this.comboBox1.Location = new System.Drawing.Point(271, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ad - Soyad:";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(306, 46);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(0, 20);
            this.lblisim.TabIndex = 18;
            // 
            // txtlimit
            // 
            this.txtlimit.Location = new System.Drawing.Point(270, 164);
            this.txtlimit.Name = "txtlimit";
            this.txtlimit.Size = new System.Drawing.Size(183, 27);
            this.txtlimit.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kart Limiti Giriniz";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(250, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "Harca";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtharca
            // 
            this.txtharca.Location = new System.Drawing.Point(190, 47);
            this.txtharca.Name = "txtharca";
            this.txtharca.Size = new System.Drawing.Size(156, 27);
            this.txtharca.TabIndex = 23;
            // 
            // lblborc
            // 
            this.lblborc.AutoSize = true;
            this.lblborc.Location = new System.Drawing.Point(632, 134);
            this.lblborc.Name = "lblborc";
            this.lblborc.Size = new System.Drawing.Size(0, 20);
            this.lblborc.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Borcunuz:";
            // 
            // txtborcode
            // 
            this.txtborcode.Location = new System.Drawing.Point(190, 141);
            this.txtborcode.Name = "txtborcode";
            this.txtborcode.Size = new System.Drawing.Size(156, 27);
            this.txtborcode.TabIndex = 27;
            // 
            // borcode
            // 
            this.borcode.BackColor = System.Drawing.Color.White;
            this.borcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borcode.ImageIndex = 2;
            this.borcode.ImageList = this.imageList1;
            this.borcode.Location = new System.Drawing.Point(250, 181);
            this.borcode.Name = "borcode";
            this.borcode.Size = new System.Drawing.Size(96, 44);
            this.borcode.TabIndex = 26;
            this.borcode.Text = "Öde";
            this.borcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borcode.UseVisualStyleBackColor = false;
            this.borcode.Click += new System.EventHandler(this.borcode_Click);
            // 
            // puanileode
            // 
            this.puanileode.BackColor = System.Drawing.Color.White;
            this.puanileode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puanileode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.puanileode.ImageIndex = 1;
            this.puanileode.ImageList = this.imageList1;
            this.puanileode.Location = new System.Drawing.Point(250, 235);
            this.puanileode.Name = "puanileode";
            this.puanileode.Size = new System.Drawing.Size(96, 44);
            this.puanileode.TabIndex = 28;
            this.puanileode.Text = "Öde";
            this.puanileode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.puanileode.UseVisualStyleBackColor = false;
            this.puanileode.Click += new System.EventHandler(this.puanileode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtlimit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 298);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluşturma";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblnumara);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbllimit);
            this.groupBox2.Controls.Add(this.lblborc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblpuan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblcvv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblisim);
            this.groupBox2.Controls.Add(this.lbltarih);
            this.groupBox2.Location = new System.Drawing.Point(29, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 180);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kart Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtharca);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.puanileode);
            this.groupBox3.Controls.Add(this.borcode);
            this.groupBox3.Controls.Add(this.txtborcode);
            this.groupBox3.Location = new System.Drawing.Point(538, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 298);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kart İşlemleri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Puanla Öde:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ödenmek İstenen Tutar:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Harcanmak İstenen Tutar:";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "mastercard-26132.png");
            this.imageList2.Images.SetKeyName(1, "American Express Logo PNG Transparent & SVG Vector - Freebie Supply.png");
            this.imageList2.Images.SetKeyName(2, "visa-logo-png-2020.png");
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.Black;
            this.lbladd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbladd.ForeColor = System.Drawing.Color.White;
            this.lbladd.Location = new System.Drawing.Point(275, 783);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(16, 25);
            this.lbladd.TabIndex = 33;
            this.lbladd.Text = "l";
            // 
            // lbldatee
            // 
            this.lbldatee.AutoSize = true;
            this.lbldatee.BackColor = System.Drawing.Color.Black;
            this.lbldatee.ForeColor = System.Drawing.Color.White;
            this.lbldatee.Location = new System.Drawing.Point(511, 725);
            this.lbldatee.Name = "lbldatee";
            this.lbldatee.Size = new System.Drawing.Size(13, 20);
            this.lbldatee.TabIndex = 34;
            this.lbldatee.Text = "l";
            this.lbldatee.Click += new System.EventHandler(this.lbldatee_Click);
            // 
            // lblkartnumara
            // 
            this.lblkartnumara.AutoSize = true;
            this.lblkartnumara.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblkartnumara.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblkartnumara.ForeColor = System.Drawing.Color.White;
            this.lblkartnumara.Location = new System.Drawing.Point(389, 669);
            this.lblkartnumara.Name = "lblkartnumara";
            this.lblkartnumara.Size = new System.Drawing.Size(194, 31);
            this.lblkartnumara.TabIndex = 32;
            this.lblkartnumara.Text = "016161611616161";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(275, 585);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(395, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 31);
            this.label14.TabIndex = 36;
            this.label14.Text = "Kart Önizleme";
            // 
            // frmCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(949, 877);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblkartnumara);
            this.Controls.Add(this.lbldatee);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCreditCard";
            this.Text = "frmCreditCard";
            this.Load += new System.EventHandler(this.frmCreditCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbllimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblcvv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.TextBox txtlimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtharca;
        private System.Windows.Forms.Label lblborc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtborcode;
        private System.Windows.Forms.Button borcode;
        private System.Windows.Forms.Button puanileode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lbldatee;
        private System.Windows.Forms.Label lblkartnumara;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
    }
}