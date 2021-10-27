namespace arackiralama
{
    partial class arackayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arackayit));
            this.textplaka = new System.Windows.Forms.TextBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.textrenk = new System.Windows.Forms.TextBox();
            this.textkm = new System.Windows.Forms.TextBox();
            this.textkira = new System.Windows.Forms.TextBox();
            this.comboseri = new System.Windows.Forms.ComboBox();
            this.comboyakit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textplaka
            // 
            this.textplaka.Location = new System.Drawing.Point(141, 51);
            this.textplaka.Name = "textplaka";
            this.textplaka.Size = new System.Drawing.Size(138, 20);
            this.textplaka.TabIndex = 0;
            // 
            // combomarka
            // 
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Items.AddRange(new object[] {
            "Renault",
            "Opel",
            "Mercedes",
            "BMW",
            "Fiat",
            "Audi",
            "Honda",
            "Range Rover",
            "Aston Martin",
            "Citroen",
            "Hyundai",
            "seat"});
            this.combomarka.Location = new System.Drawing.Point(141, 77);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(138, 21);
            this.combomarka.TabIndex = 1;
            this.combomarka.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textmodel
            // 
            this.textmodel.Location = new System.Drawing.Point(141, 131);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(138, 20);
            this.textmodel.TabIndex = 2;
            // 
            // textrenk
            // 
            this.textrenk.Location = new System.Drawing.Point(141, 157);
            this.textrenk.Name = "textrenk";
            this.textrenk.Size = new System.Drawing.Size(138, 20);
            this.textrenk.TabIndex = 3;
            // 
            // textkm
            // 
            this.textkm.Location = new System.Drawing.Point(141, 183);
            this.textkm.Name = "textkm";
            this.textkm.Size = new System.Drawing.Size(138, 20);
            this.textkm.TabIndex = 4;
            // 
            // textkira
            // 
            this.textkira.Location = new System.Drawing.Point(141, 234);
            this.textkira.Name = "textkira";
            this.textkira.Size = new System.Drawing.Size(138, 20);
            this.textkira.TabIndex = 6;
            // 
            // comboseri
            // 
            this.comboseri.FormattingEnabled = true;
            this.comboseri.Location = new System.Drawing.Point(141, 104);
            this.comboseri.Name = "comboseri";
            this.comboseri.Size = new System.Drawing.Size(138, 21);
            this.comboseri.TabIndex = 7;
            // 
            // comboyakit
            // 
            this.comboyakit.FormattingEnabled = true;
            this.comboyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Lpg"});
            this.comboyakit.Location = new System.Drawing.Point(141, 207);
            this.comboyakit.Name = "comboyakit";
            this.comboyakit.Size = new System.Drawing.Size(138, 21);
            this.comboyakit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(66, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(66, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(66, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kira Ücret";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(141, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.jpg");
            this.ımageList1.Images.SetKeyName(1, "güncelle.jpg");
            this.ımageList1.Images.SetKeyName(2, "güncelle2.jpg");
            this.ımageList1.Images.SetKeyName(3, "iptal.png");
            this.ımageList1.Images.SetKeyName(4, "sil.jpg");
            this.ımageList1.Images.SetKeyName(5, "verify.png");
            this.ımageList1.Images.SetKeyName(6, "add.png");
            this.ımageList1.Images.SetKeyName(7, "delete.png");
            this.ımageList1.Images.SetKeyName(8, "homepage.png");
            this.ımageList1.Images.SetKeyName(9, "k.png");
            this.ımageList1.Images.SetKeyName(10, "s.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 10;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(221, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 6;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(345, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 43);
            this.button3.TabIndex = 20;
            this.button3.Text = "Resim Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.Location = new System.Drawing.Point(345, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 0;
            this.button7.Location = new System.Drawing.Point(717, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 22);
            this.button7.TabIndex = 21;
            this.button7.Text = "X";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // arackayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 403);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboyakit);
            this.Controls.Add(this.comboseri);
            this.Controls.Add(this.textkira);
            this.Controls.Add(this.textkm);
            this.Controls.Add(this.textrenk);
            this.Controls.Add(this.textmodel);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.textplaka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arackayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAÇ KAYIT";
            this.Load += new System.EventHandler(this.arackayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textplaka;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.TextBox textrenk;
        private System.Windows.Forms.TextBox textkm;
        private System.Windows.Forms.TextBox textkira;
        private System.Windows.Forms.ComboBox comboseri;
        private System.Windows.Forms.ComboBox comboyakit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button7;
    }
}