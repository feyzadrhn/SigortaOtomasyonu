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
    public partial class musteriekle : Form
    {
        public musteriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader okuyucu;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
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
            SqlCommand komut = new SqlCommand("Insert Into musteriler(ad,soyad,tel,adres) values(@ad,@soyad,@tel,@adres)", baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@tel", textBox3.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select*from musteriler");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            

        }

        private void musteriekle_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * from musteriler", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "musteriler");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            da.Update(ds, "musteriler");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteriler where Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@Id",textBox5.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select * from musteriler");
            baglanti.Close();
            textBox5.Clear();
        }
    }
 }

