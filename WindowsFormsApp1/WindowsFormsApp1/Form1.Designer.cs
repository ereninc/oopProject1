namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAd_P = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.P_Foto = new System.Windows.Forms.TextBox();
            this.P_FazlaMUcreti = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.P_VergiM = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.P_FazlaMSaati = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.P_IdariGorevT = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.P_MakamT = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.P_TabanM = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.P_Es_D = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.P_Cocuk = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.P_Ev_D = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.P_Cal_Sur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.P_Yas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.P_EmekliK = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.P_GelirV = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.P_NetMaas = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.P_DamgaV = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.P_BrutM = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Personel Listesi Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(108, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 70);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(380, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Adı :";
            // 
            // lblAd_P
            // 
            this.lblAd_P.AutoSize = true;
            this.lblAd_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd_P.Location = new System.Drawing.Point(491, 96);
            this.lblAd_P.Name = "lblAd_P";
            this.lblAd_P.Size = new System.Drawing.Size(23, 16);
            this.lblAd_P.TabIndex = 5;
            this.lblAd_P.Text = "---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.P_Foto);
            this.groupBox1.Controls.Add(this.P_FazlaMUcreti);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.P_VergiM);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.P_FazlaMSaati);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.P_IdariGorevT);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.P_MakamT);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.P_TabanM);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.P_Es_D);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.P_Cocuk);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.P_Ev_D);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.P_Cal_Sur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.P_Yas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // P_Foto
            // 
            this.P_Foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_Foto.Location = new System.Drawing.Point(133, 103);
            this.P_Foto.Name = "P_Foto";
            this.P_Foto.ReadOnly = true;
            this.P_Foto.Size = new System.Drawing.Size(53, 21);
            this.P_Foto.TabIndex = 24;
            // 
            // P_FazlaMUcreti
            // 
            this.P_FazlaMUcreti.AutoSize = true;
            this.P_FazlaMUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_FazlaMUcreti.Location = new System.Drawing.Point(606, 106);
            this.P_FazlaMUcreti.Name = "P_FazlaMUcreti";
            this.P_FazlaMUcreti.Size = new System.Drawing.Size(14, 15);
            this.P_FazlaMUcreti.TabIndex = 23;
            this.P_FazlaMUcreti.Text = "x";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(445, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(135, 15);
            this.label25.TabIndex = 22;
            this.label25.Text = "Fazla Mesai Ücreti :";
            // 
            // P_VergiM
            // 
            this.P_VergiM.AutoSize = true;
            this.P_VergiM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_VergiM.Location = new System.Drawing.Point(367, 106);
            this.P_VergiM.Name = "P_VergiM";
            this.P_VergiM.Size = new System.Drawing.Size(14, 15);
            this.P_VergiM.TabIndex = 21;
            this.P_VergiM.Text = "x";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(207, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 15);
            this.label23.TabIndex = 20;
            this.label23.Text = "Vergi Matrahı :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(8, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 15);
            this.label21.TabIndex = 18;
            this.label21.Text = "Fotoğraf Uzantı :";
            // 
            // P_FazlaMSaati
            // 
            this.P_FazlaMSaati.AutoSize = true;
            this.P_FazlaMSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_FazlaMSaati.Location = new System.Drawing.Point(606, 77);
            this.P_FazlaMSaati.Name = "P_FazlaMSaati";
            this.P_FazlaMSaati.Size = new System.Drawing.Size(14, 15);
            this.P_FazlaMSaati.TabIndex = 17;
            this.P_FazlaMSaati.Text = "x";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(445, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "Fazla Mesai Saati :";
            // 
            // P_IdariGorevT
            // 
            this.P_IdariGorevT.AutoSize = true;
            this.P_IdariGorevT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_IdariGorevT.Location = new System.Drawing.Point(606, 49);
            this.P_IdariGorevT.Name = "P_IdariGorevT";
            this.P_IdariGorevT.Size = new System.Drawing.Size(14, 15);
            this.P_IdariGorevT.TabIndex = 15;
            this.P_IdariGorevT.Text = "x";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(445, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "İdari Görev Tazminatı :";
            // 
            // P_MakamT
            // 
            this.P_MakamT.AutoSize = true;
            this.P_MakamT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_MakamT.Location = new System.Drawing.Point(606, 22);
            this.P_MakamT.Name = "P_MakamT";
            this.P_MakamT.Size = new System.Drawing.Size(14, 15);
            this.P_MakamT.TabIndex = 13;
            this.P_MakamT.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(445, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Makam Tazminatı :";
            // 
            // P_TabanM
            // 
            this.P_TabanM.AutoSize = true;
            this.P_TabanM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_TabanM.Location = new System.Drawing.Point(367, 77);
            this.P_TabanM.Name = "P_TabanM";
            this.P_TabanM.Size = new System.Drawing.Size(14, 15);
            this.P_TabanM.TabIndex = 11;
            this.P_TabanM.Text = "x";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(207, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Taban Maaş :";
            // 
            // P_Es_D
            // 
            this.P_Es_D.AutoSize = true;
            this.P_Es_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_Es_D.Location = new System.Drawing.Point(367, 49);
            this.P_Es_D.Name = "P_Es_D";
            this.P_Es_D.Size = new System.Drawing.Size(14, 15);
            this.P_Es_D.TabIndex = 9;
            this.P_Es_D.Text = "x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(207, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Eşi Çalışma Durumu :";
            // 
            // P_Cocuk
            // 
            this.P_Cocuk.AutoSize = true;
            this.P_Cocuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_Cocuk.Location = new System.Drawing.Point(367, 22);
            this.P_Cocuk.Name = "P_Cocuk";
            this.P_Cocuk.Size = new System.Drawing.Size(14, 15);
            this.P_Cocuk.TabIndex = 7;
            this.P_Cocuk.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(207, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Çocuk Sayısı :";
            // 
            // P_Ev_D
            // 
            this.P_Ev_D.AutoSize = true;
            this.P_Ev_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_Ev_D.Location = new System.Drawing.Point(134, 77);
            this.P_Ev_D.Name = "P_Ev_D";
            this.P_Ev_D.Size = new System.Drawing.Size(14, 15);
            this.P_Ev_D.TabIndex = 5;
            this.P_Ev_D.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Evlilik Durumu :";
            // 
            // P_Cal_Sur
            // 
            this.P_Cal_Sur.AutoSize = true;
            this.P_Cal_Sur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_Cal_Sur.Location = new System.Drawing.Point(134, 49);
            this.P_Cal_Sur.Name = "P_Cal_Sur";
            this.P_Cal_Sur.Size = new System.Drawing.Size(14, 15);
            this.P_Cal_Sur.TabIndex = 3;
            this.P_Cal_Sur.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Çalışma Süresi :";
            // 
            // P_Yas
            // 
            this.P_Yas.AutoSize = true;
            this.P_Yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_Yas.Location = new System.Drawing.Point(134, 22);
            this.P_Yas.Name = "P_Yas";
            this.P_Yas.Size = new System.Drawing.Size(14, 15);
            this.P_Yas.TabIndex = 1;
            this.P_Yas.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yaş :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.P_EmekliK);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.P_GelirV);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.P_NetMaas);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.P_DamgaV);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.P_BrutM);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 141);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Maaş Bilgileri";
            // 
            // P_EmekliK
            // 
            this.P_EmekliK.AutoSize = true;
            this.P_EmekliK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_EmekliK.Location = new System.Drawing.Point(419, 55);
            this.P_EmekliK.Name = "P_EmekliK";
            this.P_EmekliK.Size = new System.Drawing.Size(14, 15);
            this.P_EmekliK.TabIndex = 9;
            this.P_EmekliK.Text = "x";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(293, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(118, 15);
            this.label33.TabIndex = 8;
            this.label33.Text = "Emekli Kesintisi :";
            // 
            // P_GelirV
            // 
            this.P_GelirV.AutoSize = true;
            this.P_GelirV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_GelirV.Location = new System.Drawing.Point(419, 28);
            this.P_GelirV.Name = "P_GelirV";
            this.P_GelirV.Size = new System.Drawing.Size(14, 15);
            this.P_GelirV.TabIndex = 7;
            this.P_GelirV.Text = "x";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(293, 28);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(94, 15);
            this.label35.TabIndex = 6;
            this.label35.Text = "Gelir Vergisi :";
            // 
            // P_NetMaas
            // 
            this.P_NetMaas.AutoSize = true;
            this.P_NetMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_NetMaas.ForeColor = System.Drawing.Color.Red;
            this.P_NetMaas.Location = new System.Drawing.Point(133, 95);
            this.P_NetMaas.Name = "P_NetMaas";
            this.P_NetMaas.Size = new System.Drawing.Size(17, 20);
            this.P_NetMaas.TabIndex = 5;
            this.P_NetMaas.Text = "x";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(7, 95);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 20);
            this.label30.TabIndex = 4;
            this.label30.Text = "Net Maaş :";
            // 
            // P_DamgaV
            // 
            this.P_DamgaV.AutoSize = true;
            this.P_DamgaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_DamgaV.Location = new System.Drawing.Point(134, 55);
            this.P_DamgaV.Name = "P_DamgaV";
            this.P_DamgaV.Size = new System.Drawing.Size(14, 15);
            this.P_DamgaV.TabIndex = 3;
            this.P_DamgaV.Text = "x";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(8, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 15);
            this.label28.TabIndex = 2;
            this.label28.Text = "Damga Vergisi :";
            // 
            // P_BrutM
            // 
            this.P_BrutM.AutoSize = true;
            this.P_BrutM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.P_BrutM.Location = new System.Drawing.Point(134, 28);
            this.P_BrutM.Name = "P_BrutM";
            this.P_BrutM.Size = new System.Drawing.Size(14, 15);
            this.P_BrutM.TabIndex = 1;
            this.P_BrutM.Text = "x";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(8, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Brüt Maaş :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAd_P);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAd_P;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox P_Foto;
        private System.Windows.Forms.Label P_FazlaMUcreti;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label P_VergiM;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label P_FazlaMSaati;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label P_IdariGorevT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label P_MakamT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label P_TabanM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label P_Es_D;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label P_Cocuk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label P_Ev_D;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label P_Cal_Sur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label P_Yas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label P_EmekliK;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label P_GelirV;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label P_NetMaas;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label P_DamgaV;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label P_BrutM;
        private System.Windows.Forms.Label label22;
    }
}

