using System;
using System.IO;
using System.Windows.Forms;


namespace Not_Defterim
{
    public partial class Form1 : Form
    {

        private string dosya_yolu = "";
        private bool check = true;
        private RichTextBox[] richTextBoxes = new RichTextBox[20];

        public Form1()
        {
            InitializeComponent();
            richTextBoxes[0] = richTextBox1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniYeniSayfaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string title = "Adsýz";
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Name = (tabControl1.TabCount + 1).ToString();
            //MessageBox.Show(tabControl1.TabCount.ToString());
            richTextBoxes[tabControl1.TabCount-1] = richTextBox;

            myTabPage.Controls.Add(richTextBox);
            myTabPage.Dock = DockStyle.Fill;
            richTextBox.Dock = DockStyle.Fill;

            this.check = true;

        }

        private void açDosyaSeçipÝçeriðiniGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Metin Dosyalarý|*.txt|Tüm Dosyalar|*.*";
            ofd.Title = "Bir dosya seçin";
            this.check = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.dosya_yolu = ofd.FileName;
                string dosyaYolu = ofd.FileName;
                string icerik = File.ReadAllText(dosyaYolu);
                richTextBox1.Text = icerik;
            }
        }

        private void kaydetAynýDosyayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet(this.dosya_yolu, this.check);
        }



        private void kaydet(string path, bool kontrol)
        {
            if (kontrol)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Metin Dosyasý (*.txt)|*.txt";
                saveFileDialog.Title = "Metni Kaydet";
                saveFileDialog.FileName = "metin.txt";


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(tabControl1.SelectedIndex.ToString());

                    //tabControl1.SelectedTab.Controls["richTextBox1"].Text;
                    // RichTextBox'tan düz metni al ve dosyaya yaz

                    File.WriteAllText(saveFileDialog.FileName, richTextBoxes[tabControl1.SelectedIndex].Text);
                    MessageBox.Show("Dosya baþarýyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                File.WriteAllText(path, richTextBoxes[tabControl1.SelectedIndex].Text);
                MessageBox.Show("Dosya baþarýyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void farklýKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet(this.dosya_yolu, true);

        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
