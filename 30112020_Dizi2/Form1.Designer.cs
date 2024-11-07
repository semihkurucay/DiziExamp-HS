namespace _30112020_Dizi2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecim1 = new System.Windows.Forms.TextBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.btnDoldur1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list2 = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBol = new System.Windows.Forms.TextBox();
            this.txtCarp = new System.Windows.Forms.TextBox();
            this.txtCikar = new System.Windows.Forms.TextBox();
            this.txtTopla = new System.Windows.Forms.TextBox();
            this.btnBol = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.list4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSecim1);
            this.groupBox1.Controls.Add(this.list1);
            this.groupBox1.Controls.Add(this.btnDoldur1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazdır";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(219, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 146);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen elemanın değerini textBoxa yazdırma";
            this.label1.UseMnemonic = false;
            // 
            // txtSecim1
            // 
            this.txtSecim1.Location = new System.Drawing.Point(224, 96);
            this.txtSecim1.Name = "txtSecim1";
            this.txtSecim1.Size = new System.Drawing.Size(162, 30);
            this.txtSecim1.TabIndex = 2;
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 25;
            this.list1.Location = new System.Drawing.Point(6, 96);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(212, 179);
            this.list1.TabIndex = 1;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // btnDoldur1
            // 
            this.btnDoldur1.Location = new System.Drawing.Point(6, 45);
            this.btnDoldur1.Name = "btnDoldur1";
            this.btnDoldur1.Size = new System.Drawing.Size(212, 45);
            this.btnDoldur1.TabIndex = 0;
            this.btnDoldur1.Text = "Doldur";
            this.btnDoldur1.UseVisualStyleBackColor = true;
            this.btnDoldur1.Click += new System.EventHandler(this.btnDoldur1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.list2);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eleman Sil";
            this.groupBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(219, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 176);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seçilen elemanı siliyor";
            this.label2.UseMnemonic = false;
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.ItemHeight = 25;
            this.list2.Location = new System.Drawing.Point(6, 96);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(212, 179);
            this.list2.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(6, 45);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(212, 45);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBol);
            this.groupBox3.Controls.Add(this.txtCarp);
            this.groupBox3.Controls.Add(this.txtCikar);
            this.groupBox3.Controls.Add(this.txtTopla);
            this.groupBox3.Controls.Add(this.btnBol);
            this.groupBox3.Controls.Add(this.btnCarp);
            this.groupBox3.Controls.Add(this.btnCikar);
            this.groupBox3.Controls.Add(this.btnTopla);
            this.groupBox3.Controls.Add(this.list4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.list3);
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 341);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Makinesi";
            // 
            // txtBol
            // 
            this.txtBol.Location = new System.Drawing.Point(336, 165);
            this.txtBol.Name = "txtBol";
            this.txtBol.Size = new System.Drawing.Size(180, 30);
            this.txtBol.TabIndex = 12;
            // 
            // txtCarp
            // 
            this.txtCarp.Location = new System.Drawing.Point(336, 128);
            this.txtCarp.Name = "txtCarp";
            this.txtCarp.Size = new System.Drawing.Size(180, 30);
            this.txtCarp.TabIndex = 11;
            // 
            // txtCikar
            // 
            this.txtCikar.Location = new System.Drawing.Point(336, 92);
            this.txtCikar.Name = "txtCikar";
            this.txtCikar.Size = new System.Drawing.Size(180, 30);
            this.txtCikar.TabIndex = 10;
            // 
            // txtTopla
            // 
            this.txtTopla.Location = new System.Drawing.Point(336, 54);
            this.txtTopla.Name = "txtTopla";
            this.txtTopla.Size = new System.Drawing.Size(180, 30);
            this.txtTopla.TabIndex = 9;
            // 
            // btnBol
            // 
            this.btnBol.ImageIndex = 0;
            this.btnBol.ImageList = this.ımageList1;
            this.btnBol.Location = new System.Drawing.Point(290, 165);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(40, 31);
            this.btnBol.TabIndex = 8;
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bölme.png");
            this.ımageList1.Images.SetKeyName(1, "çarpma.png");
            this.ımageList1.Images.SetKeyName(2, "çıkarma.png");
            this.ımageList1.Images.SetKeyName(3, "Toplama.png");
            // 
            // btnCarp
            // 
            this.btnCarp.ImageIndex = 1;
            this.btnCarp.ImageList = this.ımageList1;
            this.btnCarp.Location = new System.Drawing.Point(290, 128);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(40, 31);
            this.btnCarp.TabIndex = 7;
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.ImageIndex = 2;
            this.btnCikar.ImageList = this.ımageList1;
            this.btnCikar.Location = new System.Drawing.Point(290, 92);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(40, 31);
            this.btnCikar.TabIndex = 6;
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.ImageIndex = 3;
            this.btnTopla.ImageList = this.ımageList1;
            this.btnTopla.Location = new System.Drawing.Point(290, 54);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(40, 31);
            this.btnTopla.TabIndex = 5;
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // list4
            // 
            this.list4.FormattingEnabled = true;
            this.list4.ItemHeight = 25;
            this.list4.Location = new System.Drawing.Point(566, 54);
            this.list4.Name = "list4";
            this.list4.Size = new System.Drawing.Size(212, 279);
            this.list4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(290, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 119);
            this.label3.TabIndex = 3;
            this.label3.Text = "2 adet ListBox\'a random sayı oluşuyor, istenilen butona basıp seçilen işlemler ya" +
    "pılıyor";
            this.label3.UseMnemonic = false;
            // 
            // list3
            // 
            this.list3.FormattingEnabled = true;
            this.list3.ItemHeight = 25;
            this.list3.Location = new System.Drawing.Point(6, 54);
            this.list3.Name = "list3";
            this.list3.Size = new System.Drawing.Size(212, 279);
            this.list3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Aç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Aç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 688);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Gizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(839, 726);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSecim1;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button btnDoldur1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox list4;
        private System.Windows.Forms.TextBox txtBol;
        private System.Windows.Forms.TextBox txtCarp;
        private System.Windows.Forms.TextBox txtCikar;
        private System.Windows.Forms.TextBox txtTopla;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

