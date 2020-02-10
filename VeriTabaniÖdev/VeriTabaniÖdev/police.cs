using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace VeriTabaniÖdev
{
    class police
    {
        private int id;
        private string musteriad;
        private string musterisoyad;
        private string sigorta;
        private string bitisT;
        private string fiyat;


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
        public string Musteriad
        {
            get
            {
                return musteriad;
            }
            set
            {
                musteriad = value;
            }
        }
        public string Musterisoyad
        {
            get
            {
                return musterisoyad;
            }
            set
            {
                musterisoyad = value;
            }
        }
        public string Sigorta
        {
            get
            {
                return sigorta;
            }
            set
            {
                sigorta = value;
            }
        }
        public string BitisT
        {
            get
            {
                return bitisT;
            }
            set
            {
                bitisT= value;
            }
        }
        public string Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                fiyat = value;
            }
        }
        public police()
        {
            this.Id = 0;
            this.Musteriad = "";
            this.Musterisoyad = "";
            this.Sigorta = "";
            this.BitisT = "";
            this.Fiyat = "";
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader okuyucu;

        public void PoliceEkle()
        {
            komut = new SqlCommand("Insert Into tblPolice(m_ad,m_soyad,sigorta_tur,bitis_tarihi,fiyat) values(@ad,@soyad,@sigorta,@bitis,@fiyat)", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Musteriad);
            komut.Parameters.AddWithValue("@soyad", this.Musterisoyad);
            komut.Parameters.AddWithValue("@sigorta", this.Sigorta);
            komut.Parameters.AddWithValue("@bitis", this.BitisT);
            komut.Parameters.AddWithValue("@fiyat", this.Fiyat);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable PoliceGetir()
        {
            komut = new SqlCommand("Select * from tblPolice", baglanti);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            okuyucu = komut.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(okuyucu);

            return table;
        }

        public void PoliceSil()
        {
            komut = new SqlCommand("Delete From tblPolice where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.Id);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        


        public void PoliceGuncelle()
        {
            komut = new SqlCommand("Update tblPolice Set m_ad=@ad,m_soyad=@soyad,sigorta_tur= @tur,bitis_tarihi=@bitis,fiyat=@fiyat,id=@id", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Musteriad);
            komut.Parameters.AddWithValue("@soyad", this.Musterisoyad);
            komut.Parameters.AddWithValue("@tur", this.Sigorta);
            komut.Parameters.AddWithValue("@bitis", this.BitisT);
            komut.Parameters.AddWithValue("@fiyat", this.Fiyat);
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
