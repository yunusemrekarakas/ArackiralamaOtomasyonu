namespace arackiralama
{
    partial class araclistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(araclistele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ekleresim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttoniptal = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboyakit = new System.Windows.Forms.ComboBox();
            this.comboseri = new System.Windows.Forms.ComboBox();
            this.textkira = new System.Windows.Forms.TextBox();
            this.textkm = new System.Windows.Forms.TextBox();
            this.textrenk = new System.Windows.Forms.TextBox();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.textplaka = new System.Windows.Forms.TextBox();
            this.buttonsil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tüm Araçlar\t",
            "Dolu Araçlar",
            "Boş Araçlar"});
            this.comboBox1.Location = new System.Drawing.Point(794, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ekleresim
            // 
            this.ekleresim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleresim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleresim.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ekleresim.ImageIndex = 2;
            this.ekleresim.ImageList = this.ımageList1;
            this.ekleresim.Location = new System.Drawing.Point(116, 390);
            this.ekleresim.Name = "ekleresim";
            this.ekleresim.Size = new System.Drawing.Size(138, 48);
            this.ekleresim.TabIndex = 40;
            this.ekleresim.Text = "Resim Değiştir";
            this.ekleresim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekleresim.UseVisualStyleBackColor = false;
            this.ekleresim.Click += new System.EventHandler(this.ekleresim_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "güncelle.jpg");
            this.ımageList1.Images.SetKeyName(3, "homepage.png");
            this.ımageList1.Images.SetKeyName(4, "k.png");
            this.ımageList1.Images.SetKeyName(5, "s.png");
            this.ımageList1.Images.SetKeyName(6, "satis.png");
            this.ımageList1.Images.SetKeyName(7, "g.png");
            // 
            // buttoniptal
            // 
            this.buttoniptal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttoniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoniptal.ImageIndex = 5;
            this.buttoniptal.ImageList = this.ımageList1;
            this.buttoniptal.Location = new System.Drawing.Point(476, 304);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(76, 44);
            this.buttoniptal.TabIndex = 39;
            this.buttoniptal.Text = "İptal";
            this.buttoniptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoniptal.UseVisualStyleBackColor = false;
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonguncelle.ImageIndex = 7;
            this.buttonguncelle.ImageList = this.ımageList1;
            this.buttonguncelle.Location = new System.Drawing.Point(281, 304);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(96, 44);
            this.buttonguncelle.TabIndex = 38;
            this.buttonguncelle.Text = "Güncelle";
            this.buttonguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonguncelle.UseVisualStyleBackColor = false;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(44, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(37, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Kira Ücret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Plaka";
            // 
            // comboyakit
            // 
            this.comboyakit.FormattingEnabled = true;
            this.comboyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Lpg"});
            this.comboyakit.Location = new System.Drawing.Point(116, 190);
            this.comboyakit.Name = "comboyakit";
            this.comboyakit.Size = new System.Drawing.Size(138, 21);
            this.comboyakit.TabIndex = 28;
            // 
            // comboseri
            // 
            this.comboseri.FormattingEnabled = true;
            this.comboseri.Location = new System.Drawing.Point(116, 87);
            this.comboseri.Name = "comboseri";
            this.comboseri.Size = new System.Drawing.Size(138, 21);
            this.comboseri.TabIndex = 27;
            // 
            // textkira
            // 
            this.textkira.Location = new System.Drawing.Point(116, 217);
            this.textkira.Name = "textkira";
            this.textkira.Size = new System.Drawing.Size(138, 20);
            this.textkira.TabIndex = 26;
            // 
            // textkm
            // 
            this.textkm.Location = new System.Drawing.Point(116, 166);
            this.textkm.Name = "textkm";
            this.textkm.Size = new System.Drawing.Size(138, 20);
            this.textkm.TabIndex = 25;
            // 
            // textrenk
            // 
            this.textrenk.Location = new System.Drawing.Point(116, 140);
            this.textrenk.Name = "textrenk";
            this.textrenk.Size = new System.Drawing.Size(138, 20);
            this.textrenk.TabIndex = 24;
            // 
            // textmodel
            // 
            this.textmodel.Location = new System.Drawing.Point(116, 114);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(138, 20);
            this.textmodel.TabIndex = 23;
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
            ""});
            this.combomarka.Location = new System.Drawing.Point(116, 60);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(138, 21);
            this.combomarka.TabIndex = 22;
            this.combomarka.SelectedIndexChanged += new System.EventHandler(this.combomarka_SelectedIndexChanged);
            // 
            // textplaka
            // 
            this.textplaka.Location = new System.Drawing.Point(116, 34);
            this.textplaka.Name = "textplaka";
            this.textplaka.Size = new System.Drawing.Size(138, 20);
            this.textplaka.TabIndex = 21;
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsil.ImageIndex = 1;
            this.buttonsil.ImageList = this.ımageList1;
            this.buttonsil.Location = new System.Drawing.Point(383, 304);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(87, 44);
            this.buttonsil.TabIndex = 41;
            this.buttonsil.Text = "sil";
            this.buttonsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(797, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(732, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Durum";
            // 
            // araclistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(997, 464);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.ekleresim);
            this.Controls.Add(this.buttoniptal);
            this.Controls.Add(this.buttonguncelle);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "araclistele";
            this.Text = "ARAÇ LİSTESİ VE GÜNCELLEME";
            this.Load += new System.EventHandler(this.araclistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ekleresim;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboyakit;
        private System.Windows.Forms.ComboBox comboseri;
        private System.Windows.Forms.TextBox textkira;
        private System.Windows.Forms.TextBox textkm;
        private System.Windows.Forms.TextBox textrenk;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.TextBox textplaka;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label9;
    }
}