using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VeriTabaniÖdev
{
    class musteri
    {
        private int id;
        private string ad;
        private string soyad;
        private string tel;
        private string adres;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }
        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }

        public musteri()
        {
            this.Id = 0;
            this.Ad = "";
            this.Soyad = "";
            this.Tel = "";
            this.Adres = "";
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader okuyucu;

        public void MusteriEkle()
        {
            komut = new SqlCommand("Insert Into musteriler(ad,soyad,tel,adres) values(@ad,@soyad,@tel,@adres)", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Ad);
            komut.Parameters.AddWithValue("@soyad",this.Soyad);
            komut.Parameters.AddWithValue("@tel", this.Tel);
            komut.Parameters.AddWithValue("@adres", this.Adres);
            

            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            
            komut.ExecuteNonQuery();
            
            baglanti.Close();
        }
       
        public DataTable MusteriGetir()
        {
            komut = new SqlCommand("Select * from musteriler", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            okuyucu = komut.ExecuteReader();
           

            DataTable table = new DataTable();
            table.Load(okuyucu);

            return table;
        }
        public void MusteriSil()
        {
            komut = new SqlCommand("Delete From musteriler where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.Id);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
           
            baglanti.Close();

        }
        public void MusteriGetirId()
        {
            komut = new SqlCommand("Select * From musteriler where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.Id);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            okuyucu = komut.ExecuteReader(CommandBehavior.CloseConnection);
            okuyucu.Read();
            this.Ad = okuyucu["ad"].ToString();
            this.Soyad = okuyucu["soyad"].ToString();
            this.Tel = okuyucu["tel"].ToString();
            this.Adres = okuyucu["adres"].ToString();

            baglanti.Close();
        }
        public void MusteriGuncelle()
        {
            komut = new SqlCommand("Update musteriler Set ad=@ad,soyad=@soyad,tel= @tel ,adres=@adres,id=@id", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Ad);
            komut.Parameters.AddWithValue("@soyad", this.Soyad);
            komut.Parameters.AddWithValue("@tel", this.Tel);
            komut.Parameters.AddWithValue("@adres", this.Adres);
            komut.Parameters.AddWithValue("@id", this.Id);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

    }

}


