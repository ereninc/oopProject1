using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2018-2019 BAHAR DÖNEMİ
**	
**				  ÖDEV NUMARASI..........: ÖDEV NO - 1
**				  ÖĞRENCİ ADI............: Erencan İNANCI
**				  ÖĞRENCİ NUMARASI.......: B171210308
**                DERSİN ALINDIĞI GRUP...: 2. Öğretim / B Grubu
****************************************************************************/

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string TC;
        string Ad;
        string Soyad;
        double brutMaas;
        double tabanMaas;
        double makamTazminat;
        double idariGorevTazminat;
        char evlilikDurumu;
        double emekliKesinti;
        double gelirVergisi;
        double damgaVergisi;
        char esDurumu;
        double vergiMatrahi;
        double NetMaas;
        int cocukSay;
        double fazlaMesaiSaat;
        double fazlaMesaiUcret;
        string foto;
        int yas;
        int calismaSuresi;
        string[] kelimeler;
        string[] kullanim = new string[100];
        int diziSayac = 0;

        public string[] Kelimeler { get => kelimeler; set => kelimeler = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            var lineCount = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = s;
            }

            //personel sayisi fazla arttığı durumlar için bugfix
            using (var reader = File.OpenText(openFileDialog1.FileName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            
            Array.Resize<string>(ref kullanim, lineCount* 15);
            
            string[] satirlar;
            String metin = richTextBox1.Text;
            satirlar = metin.Split('\n');
            foreach (string s in satirlar)
            {
                Kelimeler = s.Split(' ');
                comboBox1.Items.Add(Kelimeler[0]);
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    kullanim[i+ diziSayac] = kelimeler[i];
                }
                diziSayac += 15;
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //diziyi doldurmak için gerekli kod bloğu.
            int comboBoxIndex = comboBox1.SelectedIndex;
            TC = Convert.ToString(kullanim[(comboBoxIndex * 14) + 0 + comboBoxIndex]);
            Ad = Convert.ToString(kullanim[(comboBoxIndex * 14) + 1 + comboBoxIndex]);
            Soyad = Convert.ToString(kullanim[(comboBoxIndex * 14) + 2 + comboBoxIndex]);
            yas = Convert.ToInt32(kullanim[(comboBoxIndex * 14) + 3 + comboBoxIndex]);
            calismaSuresi = Convert.ToInt32(kullanim[(comboBoxIndex * 14) + 4 + comboBoxIndex]);
            evlilikDurumu = Convert.ToChar(kullanim[(comboBoxIndex * 14) + 5 + comboBoxIndex]);
            esDurumu = Convert.ToChar(kullanim[(comboBoxIndex * 14) + 6 + comboBoxIndex]);
            cocukSay = Convert.ToInt16(kullanim[(comboBoxIndex * 14) + 7 + comboBoxIndex]);
            tabanMaas = Convert.ToDouble(kullanim[(comboBoxIndex * 14) + 8 + comboBoxIndex]);
            makamTazminat = Convert.ToDouble(kullanim[(comboBoxIndex * 14) + 9 + comboBoxIndex]);
            idariGorevTazminat = Convert.ToDouble(kullanim[(comboBoxIndex * 14) + 10 + comboBoxIndex]);
            fazlaMesaiSaat = Convert.ToDouble(kullanim[(comboBoxIndex * 14) + 11 + comboBoxIndex]);
            fazlaMesaiUcret = Convert.ToDouble(kullanim[(comboBoxIndex * 14) + 12 + comboBoxIndex]);
            vergiMatrahi = Convert.ToDouble(kullanim[(comboBoxIndex * 14) + 13 + comboBoxIndex]);
            foto = kullanim[(comboBoxIndex * 14) + 14 + comboBoxIndex];

            //labelları doldurma kısmı
            lblAd_P.Text = (Ad + " " + Soyad);
            P_Yas.Text = (yas.ToString());
            P_Cal_Sur.Text = (calismaSuresi.ToString());
            P_Cocuk.Text = (cocukSay.ToString());
            P_Es_D.Text = (esDurumu.ToString());
            P_Ev_D.Text = (evlilikDurumu.ToString());
            P_TabanM.Text = (tabanMaas.ToString());
            P_MakamT.Text = (makamTazminat.ToString());
            P_FazlaMSaati.Text = (fazlaMesaiSaat.ToString());
            P_FazlaMUcreti.Text = (fazlaMesaiUcret.ToString());
            P_IdariGorevT.Text = (idariGorevTazminat.ToString());
            P_VergiM.Text = (vergiMatrahi.ToString());
            P_Foto.Text = (foto);
            
            //hesaplama işlemleri
            if (evlilikDurumu == 'B')
            {
                brutMaas = (tabanMaas + makamTazminat + idariGorevTazminat + (cocukSay * 30) + (fazlaMesaiSaat * fazlaMesaiUcret));
            }
            else if (evlilikDurumu == 'E' && esDurumu == 'E')
            {
                brutMaas = (tabanMaas + makamTazminat + idariGorevTazminat + (cocukSay * 30) + (fazlaMesaiSaat * fazlaMesaiUcret));
            }
            else
            {
                brutMaas = (tabanMaas + makamTazminat + idariGorevTazminat + 200 + (cocukSay * 30) + (fazlaMesaiSaat * fazlaMesaiUcret));
            }

            if (vergiMatrahi < 10000)
            {
                gelirVergisi = ((brutMaas * 15) / 100);
                P_GelirV.Text = gelirVergisi.ToString();
            }
            else if (vergiMatrahi >= 10000 && vergiMatrahi < 20000)
            {
                gelirVergisi = ((brutMaas * 20) / 100);
                P_GelirV.Text = gelirVergisi.ToString();
            }
            else if (vergiMatrahi >= 20000 && vergiMatrahi < 30000)
            {
                gelirVergisi = ((brutMaas * 25) / 100);
                P_GelirV.Text = gelirVergisi.ToString();
            }
            else
            {
                gelirVergisi = ((brutMaas * 30) / 100);
                P_GelirV.Text = gelirVergisi.ToString();
            }

            //labellara yazdırma ve hesaplama işlemleri
            emekliKesinti = (brutMaas * 15) / 100;
            damgaVergisi = (brutMaas * 10) / 100;
            P_BrutM.Text = brutMaas.ToString();
            P_DamgaV.Text = damgaVergisi.ToString();
            P_EmekliK.Text = emekliKesinti.ToString();
            NetMaas = (brutMaas - (emekliKesinti + gelirVergisi + damgaVergisi));
            P_NetMaas.Text = NetMaas.ToString();
        }
    }
}
