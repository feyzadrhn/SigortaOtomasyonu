using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace VeriTabaniÖdev
{
    class sigorta
    {
        private int id;
        private string sigorta_tur;

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
        public string Sigorta_tur
        {
            get
            {
                return sigorta_tur;
            }
            set
            {
                sigorta_tur= value;
            }
        }
        public sigorta()
        {
            this.Sigorta_tur = "";
            this.Id = 0;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9770QPS\SQLEXPRESS;Initial Catalog=veritabani;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader okuyucu;
        
        public void SigortaEkle()
        {
            komut = new SqlCommand("Insert Into tblSigorta(sigorta_turu) values(@sigorta)", baglanti);
            komut.Parameters.AddWithValue("@sigorta", this.Sigorta_tur);
           
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable SigortaGetir()
        {
            komut = new SqlCommand("Select * from tblSigorta", baglanti);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            okuyucu = komut.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(okuyucu);

            return table;
        }
        public void SigortaSil()
        {
            komut = new SqlCommand("Delete From tblSigorta where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.Id);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public void SigortaGetirId()
        {
            komut = new SqlCommand("Select * From tblSigorta where id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.Id);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            okuyucu = komut.ExecuteReader(CommandBehavior.CloseConnection);
            okuyucu.Read();
            this.Sigorta_tur = okuyucu["sigorta_turu"].ToString();
            

            baglanti.Close();
        }
        public void SigortaGuncelle()
        {
            komut = new SqlCommand("Update tblSigorta Set sigorta_turu=@tur where id=@id", baglanti);
            komut.Parameters.AddWithValue("@tur", this.Sigorta_tur);
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
