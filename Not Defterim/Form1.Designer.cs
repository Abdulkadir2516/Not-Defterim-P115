﻿namespace Not_Defterim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniYeniSayfaAçToolStripMenuItem = new ToolStripMenuItem();
            açDosyaSeçipİçeriğiniGetirToolStripMenuItem = new ToolStripMenuItem();
            kaydetAynıDosyayaToolStripMenuItem = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            geriAlToolStripMenuItem = new ToolStripMenuItem();
            tümünüSeçToolStripMenuItem = new ToolStripMenuItem();
            kesKopyalaYapıştırToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiSeçToolStripMenuItem = new ToolStripMenuItem();
            temaDeğiştirAçıkKoyuToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            hakkındaUygulamaBilgisiToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            tümSekmeleriKapatToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem1 = new ToolStripMenuItem();
            yapıştırToolStripMenuItem1 = new ToolStripMenuItem();
            tümünüSeçToolStripMenuItem1 = new ToolStripMenuItem();
            geriAlToolStripMenuItem1 = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, görünümToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniYeniSayfaAçToolStripMenuItem, açDosyaSeçipİçeriğiniGetirToolStripMenuItem, kaydetAynıDosyayaToolStripMenuItem, farklıKaydetToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniYeniSayfaAçToolStripMenuItem
            // 
            yeniYeniSayfaAçToolStripMenuItem.Name = "yeniYeniSayfaAçToolStripMenuItem";
            yeniYeniSayfaAçToolStripMenuItem.Size = new Size(242, 22);
            yeniYeniSayfaAçToolStripMenuItem.Text = "Yeni (Yeni sayfa aç)";
            yeniYeniSayfaAçToolStripMenuItem.Click += yeniYeniSayfaAçToolStripMenuItem_Click;
            // 
            // açDosyaSeçipİçeriğiniGetirToolStripMenuItem
            // 
            açDosyaSeçipİçeriğiniGetirToolStripMenuItem.Name = "açDosyaSeçipİçeriğiniGetirToolStripMenuItem";
            açDosyaSeçipİçeriğiniGetirToolStripMenuItem.Size = new Size(242, 22);
            açDosyaSeçipİçeriğiniGetirToolStripMenuItem.Text = "Aç… (Dosya seçip içeriğini getir)";
            açDosyaSeçipİçeriğiniGetirToolStripMenuItem.Click += açDosyaSeçipİçeriğiniGetirToolStripMenuItem_Click;
            // 
            // kaydetAynıDosyayaToolStripMenuItem
            // 
            kaydetAynıDosyayaToolStripMenuItem.Name = "kaydetAynıDosyayaToolStripMenuItem";
            kaydetAynıDosyayaToolStripMenuItem.Size = new Size(242, 22);
            kaydetAynıDosyayaToolStripMenuItem.Text = "Kaydet (Aynı dosyaya)";
            kaydetAynıDosyayaToolStripMenuItem.Click += kaydetAynıDosyayaToolStripMenuItem_Click;
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(242, 22);
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet…";
            farklıKaydetToolStripMenuItem.Click += farklıKaydetToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(242, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geriAlToolStripMenuItem, tümünüSeçToolStripMenuItem, kesKopyalaYapıştırToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // geriAlToolStripMenuItem
            // 
            geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            geriAlToolStripMenuItem.Size = new Size(141, 22);
            geriAlToolStripMenuItem.Text = "Geri Al";
            geriAlToolStripMenuItem.Click += geriAlToolStripMenuItem_Click;
            // 
            // tümünüSeçToolStripMenuItem
            // 
            tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            tümünüSeçToolStripMenuItem.Size = new Size(141, 22);
            tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            tümünüSeçToolStripMenuItem.Click += tümünüSeçToolStripMenuItem_Click;
            // 
            // kesKopyalaYapıştırToolStripMenuItem
            // 
            kesKopyalaYapıştırToolStripMenuItem.Name = "kesKopyalaYapıştırToolStripMenuItem";
            kesKopyalaYapıştırToolStripMenuItem.Size = new Size(141, 22);
            kesKopyalaYapıştırToolStripMenuItem.Text = "Kes";
            kesKopyalaYapıştırToolStripMenuItem.Click += kesKopyalaYapıştırToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(141, 22);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(141, 22);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıTipiSeçToolStripMenuItem, temaDeğiştirAçıkKoyuToolStripMenuItem });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(70, 20);
            görünümToolStripMenuItem.Text = "Görünüm";
            görünümToolStripMenuItem.Click += görünümToolStripMenuItem_Click;
            // 
            // yazıTipiSeçToolStripMenuItem
            // 
            yazıTipiSeçToolStripMenuItem.Name = "yazıTipiSeçToolStripMenuItem";
            yazıTipiSeçToolStripMenuItem.Size = new Size(212, 22);
            yazıTipiSeçToolStripMenuItem.Text = "Yazı Tipi Seç…";
            yazıTipiSeçToolStripMenuItem.Click += yazıTipiSeçToolStripMenuItem_Click;
            // 
            // temaDeğiştirAçıkKoyuToolStripMenuItem
            // 
            temaDeğiştirAçıkKoyuToolStripMenuItem.Name = "temaDeğiştirAçıkKoyuToolStripMenuItem";
            temaDeğiştirAçıkKoyuToolStripMenuItem.Size = new Size(212, 22);
            temaDeğiştirAçıkKoyuToolStripMenuItem.Text = "Tema Değiştir (Açık/Koyu)";
            temaDeğiştirAçıkKoyuToolStripMenuItem.Click += temaDeğiştirAçıkKoyuToolStripMenuItem_Click;
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkındaUygulamaBilgisiToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(56, 20);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaUygulamaBilgisiToolStripMenuItem
            // 
            hakkındaUygulamaBilgisiToolStripMenuItem.Name = "hakkındaUygulamaBilgisiToolStripMenuItem";
            hakkındaUygulamaBilgisiToolStripMenuItem.Size = new Size(223, 22);
            hakkındaUygulamaBilgisiToolStripMenuItem.Text = "Hakkında (Uygulama bilgisi)";
            hakkındaUygulamaBilgisiToolStripMenuItem.Click += hakkındaUygulamaBilgisiToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 622);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(808, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(118, 17);
            toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(118, 17);
            toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // tabControl1
            // 
            tabControl1.ContextMenuStrip = contextMenuStrip1;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 30);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 592);
            tabControl1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, tümSekmeleriKapatToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(190, 92);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(189, 22);
            toolStripMenuItem1.Text = "Yeni Sekme Aç";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(189, 22);
            toolStripMenuItem2.Text = "Sekmeyi Kapat";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(189, 22);
            toolStripMenuItem3.Text = "Diğer Sekmeleri Kapat";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // tümSekmeleriKapatToolStripMenuItem
            // 
            tümSekmeleriKapatToolStripMenuItem.Name = "tümSekmeleriKapatToolStripMenuItem";
            tümSekmeleriKapatToolStripMenuItem.Size = new Size(189, 22);
            tümSekmeleriKapatToolStripMenuItem.Text = "Tüm Sekmeleri Kapat";
            tümSekmeleriKapatToolStripMenuItem.Click += tümSekmeleriKapatToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 558);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adsız";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip2;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(794, 552);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem1, yapıştırToolStripMenuItem1, tümünüSeçToolStripMenuItem1, geriAlToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(142, 114);
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(141, 22);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem1
            // 
            kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            kopyalaToolStripMenuItem1.Size = new Size(141, 22);
            kopyalaToolStripMenuItem1.Text = "Kopyala";
            kopyalaToolStripMenuItem1.Click += kopyalaToolStripMenuItem1_Click;
            // 
            // yapıştırToolStripMenuItem1
            // 
            yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            yapıştırToolStripMenuItem1.Size = new Size(141, 22);
            yapıştırToolStripMenuItem1.Text = "Yapıştır";
            yapıştırToolStripMenuItem1.Click += yapıştırToolStripMenuItem1_Click;
            // 
            // tümünüSeçToolStripMenuItem1
            // 
            tümünüSeçToolStripMenuItem1.Name = "tümünüSeçToolStripMenuItem1";
            tümünüSeçToolStripMenuItem1.Size = new Size(141, 22);
            tümünüSeçToolStripMenuItem1.Text = "Tümünü Seç";
            tümünüSeçToolStripMenuItem1.Click += tümünüSeçToolStripMenuItem1_Click;
            // 
            // geriAlToolStripMenuItem1
            // 
            geriAlToolStripMenuItem1.Name = "geriAlToolStripMenuItem1";
            geriAlToolStripMenuItem1.Size = new Size(141, 22);
            geriAlToolStripMenuItem1.Text = "Geri Al";
            geriAlToolStripMenuItem1.Click += geriAlToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(808, 644);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniYeniSayfaAçToolStripMenuItem;
        private ToolStripMenuItem açDosyaSeçipİçeriğiniGetirToolStripMenuItem;
        private ToolStripMenuItem kaydetAynıDosyayaToolStripMenuItem;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem geriAlToolStripMenuItem;
        private ToolStripMenuItem kesKopyalaYapıştırToolStripMenuItem;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem yazıTipiSeçToolStripMenuItem;
        private ToolStripMenuItem temaDeğiştirAçıkKoyuToolStripMenuItem;
        private ToolStripMenuItem hakkındaUygulamaBilgisiToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private TabPage tabPage1;
        private RichTextBox richTextBox1;
        public TabControl tabControl1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem tümSekmeleriKapatToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem1;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripMenuItem tümünüSeçToolStripMenuItem1;
        private ToolStripMenuItem geriAlToolStripMenuItem1;
        private FontDialog fontDialog1;
    }
}
