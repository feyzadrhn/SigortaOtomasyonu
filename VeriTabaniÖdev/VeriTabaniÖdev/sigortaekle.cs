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
    public partial class sigortaekle : Form
    {
        public sigortaekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        SqlCommand komut;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        private void sigortaekle_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * from sigorta_", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "sigorta_");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        public void Verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into sigorta_(sigorta_turu) values(@sigorta_turu)", baglanti);
            komut.Parameters.AddWithValue("@sigorta_turu", comboBox1.Text);
            komut.ExecuteNonQuery();
            Verilerigoster("select*from sigorta_");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sigorta_ where Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@Id", textBox5.Text);
            komut.ExecuteNonQuery();
            Verilerigoster("select * from sigorta_");
            baglanti.Close();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Update(ds, "sigorta_");
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
