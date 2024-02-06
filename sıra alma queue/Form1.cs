using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sıra_alma_queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<int> queue = new Queue<int>(); //Tüm butonlardan erişilebilmesi için Global tanımlama yaptık.

        int sayac = 1;

        private void btnSiraAl_Click(object sender, EventArgs e)
        {

            queue.Enqueue(sayac); 
            lblSiraAl.Text = sayac.ToString(); 
            sayac++;


        }

        private void btnGise1_Click(object sender, EventArgs e)
        {

            lblGise1.Text = SiraCagir();
        }

        private void btnGise2_Click(object sender, EventArgs e)
        {
            lblGise2.Text = SiraCagir();
        }

        private void btnGise3_Click(object sender, EventArgs e)
        {
            lblGise3.Text = SiraCagir();

            private string SiraCagir()
            {
                if (queue.Count > 0)
                {
                    string sira = queue.Dequeue().ToString(); //Kuyruktan önce girilen değeri kaldırdık.
                    return sira;
                }
                else
                {
                    return "Musteri yok..";
                }

            }

        }
    }
}
