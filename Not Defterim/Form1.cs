using System;
using System.IO;
using System.Windows.Forms;





namespace Not_Defterim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniYeniSayfaA�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void a�DosyaSe�ip��eri�iniGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Dosyalar�|*.txt|T�m Dosyalar|*.*";
            ofd.Title = "Bir dosya se�in";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = ofd.FileName;
                string icerik = File.ReadAllText(dosyaYolu);
                richTextBox1.Text = icerik;
            }
        }
    }


}
