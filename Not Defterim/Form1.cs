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

        private void yeniYeniSayfaA�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_new_page();

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
                    //MessageBox.Show(tabControl1.SelectedIndex.ToString());

                    //tabControl1.SelectedTab.Controls["richTextBox1"].Text;
                    // RichTextBox'tan d�z metni al ve dosyaya yaz

                    File.WriteAllText(saveFileDialog.FileName, richTextBoxes[tabControl1.SelectedIndex].Text);
                    MessageBox.Show("Dosya ba�ar�yla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                File.WriteAllText(path, richTextBoxes[tabControl1.SelectedIndex].Text);
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

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            open_new_page();
        }

        private void open_new_page()
        {

            TabPage myTabPage = new TabPage("Ads�z " + tabControl1.TabCount);
            tabControl1.TabPages.Add(myTabPage);
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Name = (tabControl1.TabCount + 1).ToString();
            //MessageBox.Show(tabControl1.TabCount.ToString());
            richTextBoxes[tabControl1.TabCount - 1] = richTextBox;

            myTabPage.Controls.Add(richTextBox);
            myTabPage.Dock = DockStyle.Fill;
            richTextBox.Dock = DockStyle.Fill;

            this.check = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.TabPages[tabControl1.SelectedIndex]);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            for (int i = tabControl1.TabCount - 1; i > -1; i--)
            {
                if (tabControl1.TabPages[tabControl1.SelectedIndex] != tabControl1.TabPages[i])
                {
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);

                }
            }
        }

        private void t�mSekmeleriKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = tabControl1.TabCount - 1; i > -1; i--)
            {

                tabControl1.TabPages.Remove(tabControl1.TabPages[i]);


            }
        }

        private void g�r�n�mToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kesKopyalaYap��t�rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Cut();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Undo();

        }

        private void t�m�n�Se�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].SelectAll();

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Copy();
        }

        private void yap��t�rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Paste();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Cut();

        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Copy();

        }

        private void yap��t�rToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Paste();

        }

        private void t�m�n�Se�ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].SelectAll();

        }

        private void geriAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Undo();

        }
    }


}
