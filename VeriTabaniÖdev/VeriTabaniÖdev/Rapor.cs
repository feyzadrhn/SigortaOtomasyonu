using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabaniÖdev
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        private void Rapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabaniDataSet2.police' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.policeTableAdapter.Fill(this.veritabaniDataSet2.police);
            // TODO: Bu kod satırı 'veritabaniDataSet2.musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.veritabaniDataSet2.musteriler);

        }
     
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapor1 rapor = new Rapor1();
            rapor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rapor3 rapor = new Rapor3();
            rapor.Show();



        }
       
         private void button2_Click(object sender, EventArgs e)
        {
            Rapor2 rapor = new Rapor2();
            rapor.Show();

        }
    }
}
