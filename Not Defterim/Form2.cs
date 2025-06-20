﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Not_Defterim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ziyaret edildiği zaman linkin renginin değişimini sağlamak için LinkVisited'a true değeri atanır.
            linkLabel1.LinkVisited = true;

            var url = "https://github.com/Abdulkadir2516/Not-Defterim-P115";

            try
            {
                OpenUrl(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }


        public static void OpenUrl(string url)
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw new NotSupportedException("Desteklenmeyen işletim sistemi");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"URL açma hatası: {ex.Message}");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ziyaret edildiği zaman linkin renginin değişimini sağlamak için LinkVisited'a true değeri atanır.
            linkLabel1.LinkVisited = true;

            var url = "https://www.linkedin.com/in/abdulkadir-yesilkaya-872a95256/";

            try
            {
                OpenUrl(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ziyaret edildiği zaman linkin renginin değişimini sağlamak için LinkVisited'a true değeri atanır.
            linkLabel1.LinkVisited = true;

            var url = "https://greenrock.gen.tr/";

            try
            {
                OpenUrl(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
