using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniÖdev
{
    public partial class Rapor1 : Form
    {
        public Rapor1()
        {
            InitializeComponent();
        }

        private void Rapor1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabaniDataSet2.musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.veritabaniDataSet2.musteriler);

        }
    }
}
