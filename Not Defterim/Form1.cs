using System;
using System.IO;
using System.Windows.Forms;


namespace Not_Defterim
{
    public partial class Form1 : Form
    {

        private string dosya_yolu = "";
        private bool check = true;
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
            this.check = true;

        }

        private void a�DosyaSe�ip��eri�iniGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Dosyalar�|*.txt|T�m Dosyalar|*.*";
            ofd.Title = "Bir dosya se�in";
            this.check = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.dosya_yolu = ofd.FileName;
                string dosyaYolu = ofd.FileName;
                string icerik = File.ReadAllText(dosyaYolu);
                richTextBox1.Text = icerik;
            }
        }

        private void kaydetAyn�DosyayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet(this.dosya_yolu, this.check);
        }



        private void kaydet(string path, bool kontrol)
        {
            if (kontrol)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Metin Dosyas� (*.txt)|*.txt";
                saveFileDialog.Title = "Metni Kaydet";
                saveFileDialog.FileName = "metin.txt";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // RichTextBox'tan d�z metni al ve dosyaya yaz
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    MessageBox.Show("Dosya ba�ar�yla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                File.WriteAllText(path, richTextBox1.Text);
                MessageBox.Show("Dosya ba�ar�yla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void farkl�KaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet(this.dosya_yolu, true);

        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
