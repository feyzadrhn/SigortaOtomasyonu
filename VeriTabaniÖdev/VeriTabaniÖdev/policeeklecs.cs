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
using System.Data.OleDb;
namespace VeriTabaniÖdev
{
    public partial class policeeklecs : Form
    {
        public policeeklecs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        SqlConnection bag = new SqlConnection(@"Data Source = DESKTOP - 9770QPS\SQLEXPRESS;Initial Catalog = veritabani; Integrated Security = True");
        private void policeeklecs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabaniDataSet2.sigorta_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sigorta_TableAdapter.Fill(this.veritabaniDataSet2.sigorta_);
            // TODO: Bu kod satırı 'veritabaniDataSet2.musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.veritabaniDataSet2.musteriler);
            // TODO: Bu kod satırı 'veritabaniDataSet2.police' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.policeTableAdapter.Fill(this.veritabaniDataSet2.police);

            con = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * from police", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "police");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();



        }
        SqlCommand komut = new SqlCommand();
        SqlCommand kmt = new SqlCommand();
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Insert Into police(m_ad,m_soyad,sigorta_tur,bitis_tarihi,fiyat) values(@m_ad,@m_soyad,@sigorta_tur,@bitis_tarihi,@fiyat)", baglanti);
            komut.Parameters.AddWithValue("@m_ad", comboBox1.Text);
            komut.Parameters.AddWithValue("@m_soyad", comboBox2.Text);
            komut.Parameters.AddWithValue("@sigorta_tur", comboBox3.Text);
            komut.Parameters.AddWithValue("@bitis_tarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select *from police");

            baglanti.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from police where Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@Id", textBox5.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select * from police");
            baglanti.Close();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            da.Update(ds, "police");
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
