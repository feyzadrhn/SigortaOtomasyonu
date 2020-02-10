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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle fr = new musteriekle();
            fr.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sigortaekle s = new sigortaekle();
            s.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            policeeklecs pe = new policeeklecs();
            pe.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Rapor r = new Rapor();
            r.Show();
        }
    }
}
