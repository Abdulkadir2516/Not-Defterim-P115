using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Not_Defterim

{
    public partial class Form1 : Form
    {
        private Color arkaplan_rengi = Color.White;
        private Color yazi_rengi = Color.Black;
        private string dosya_yolu = "";
        private bool check = true;
        private RichTextBox[] richTextBoxes = new RichTextBox[20];

        private void tema_degistir()
        {

            this.BackColor = arkaplan_rengi;
            this.ForeColor = yazi_rengi;
            menuStrip1.BackColor = arkaplan_rengi;
            menuStrip1.ForeColor = yazi_rengi;
            tabPage1.BackColor = arkaplan_rengi;
            tabPage1.ForeColor = yazi_rengi;
            richTextBox1.BackColor = arkaplan_rengi;
            richTextBox1.ForeColor = yazi_rengi;

            for (int i = tabControl1.TabCount - 1; i > -1; i--)
            {

                richTextBoxes[i].BackColor = arkaplan_rengi;
                richTextBoxes[i].ForeColor = yazi_rengi;


            }
        }
        public Form1()
        {
            InitializeComponent();
            richTextBoxes[0] = richTextBox1;

            tema_degistir();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniYeniSayfaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_new_page();

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

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            open_new_page();
        }

        private void open_new_page()
        {

            TabPage myTabPage = new TabPage("Adsýz " + tabControl1.TabCount);
            tabControl1.TabPages.Add(myTabPage);
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Name = (tabControl1.TabCount + 1).ToString();
            //MessageBox.Show(tabControl1.TabCount.ToString());
            richTextBoxes[tabControl1.TabCount - 1] = richTextBox;

            myTabPage.Controls.Add(richTextBox);
            myTabPage.Dock = DockStyle.Fill;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ContextMenuStrip = contextMenuStrip1;
            myTabPage.BackColor = arkaplan_rengi;
            myTabPage.ForeColor = yazi_rengi;
            richTextBox.BackColor = arkaplan_rengi;
            richTextBox.ForeColor = yazi_rengi;
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

        private void tümSekmeleriKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = tabControl1.TabCount - 1; i > -1; i--)
            {

                tabControl1.TabPages.Remove(tabControl1.TabPages[i]);


            }
        }

        private void görünümToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kesKopyalaYapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].SelectAll();

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Copy();
        }

        private void yapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void yapýþtýrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Paste();

        }

        private void tümünüSeçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].SelectAll();

        }

        private void geriAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxes[tabControl1.SelectedIndex].Undo();

        }

        private void yazýTipiSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void temaDeðiþtirAçýkKoyuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arkaplan_rengi == Color.White)
            {
                arkaplan_rengi = Color.Black;
                yazi_rengi = Color.White;
            }
            else
            {
                arkaplan_rengi = Color.White;
                yazi_rengi = Color.Black;
            }
            tema_degistir();
        }

        private void hakkýndaUygulamaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  

        }
    }


}
