using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downloadauto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var download = new WebClient();

            string[] url = {

                @"https://aka.ms/ssmsfullsetup?clcid=0x416",

                @"https://aka.ms/ssmsfullsetup?clcid=0x409",

            };

            string destino = @"C:\DEV\";

            string[] nome =
            {
                "pt.exe",
                "eua.exe",

            };

            download.DownloadFile(url[0],  destino + nome[0] );
            download.DownloadFile(url[1], destino + nome[1]);


            MessageBox.Show("download concluido");

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }
    }
}
