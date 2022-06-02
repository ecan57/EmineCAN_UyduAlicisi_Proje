using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyduAlicisi.Model;

namespace UyduAlicisi.Data
{
    class Kanallar : ICrud<Kanal>
    {
        SqlConnection Conn;

        public Kanallar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }

        public Kanal Bul(int id)
        {
            Conn.Open();
            
            Kanal kanal = new Kanal();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kanallar WHERE KanalID = @ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            
            kanal.KanalID = -1;
            
            if (dr.HasRows)
            {
                kanal.KanalID = Convert.ToInt32(dr[0]);
                kanal.KanalAdi = dr.GetString(1);
                kanal.Frekans = Convert.ToInt32(dr[2]);
                kanal.YayinAdi = dr.GetString(3);
                kanal.Dil = dr.GetString(4);
                kanal.HDmi = Convert.ToBoolean(dr[5]);
                kanal.RadyoID = Convert.ToInt32(dr[6]);
            }
            Conn.Close();
            
            return kanal;
        }

        public void Ekle(Kanal model)
        {
            Conn.Open();
            
            SqlCommand cmd = new SqlCommand("INSERT INTO Kanallar VALUES (@ad, @frekans, @yayin, @dil, @hd, @radyoid)", Conn);
            
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", model.KanalAdi);
            cmd.Parameters.AddWithValue("@frekans", model.Frekans);
            cmd.Parameters.AddWithValue("@yayin", model.YayinAdi);
            cmd.Parameters.AddWithValue("@dil", model.Dil);
            cmd.Parameters.AddWithValue("@hd", model.HDmi);
            cmd.Parameters.AddWithValue("@radyoid", model.RadyoID);
            cmd.ExecuteNonQuery();
            
            Conn.Close();
        }

        public void Guncelle(Kanal model)
        {
            Conn.Open();
            
            SqlCommand cmd = new SqlCommand("UPDATE Kanallar SET KanalAdi = @ad, Frekans = @frekans, YayinAdi = @yayin, Dil = @dil, HDmi = @hd, RadyoID = @Radyoid WHERE KanalID = @ID", Conn);
            
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.KanalID);
            cmd.Parameters.AddWithValue("@ad", model.KanalAdi);
            cmd.Parameters.AddWithValue("@frekans", model.Frekans);
            cmd.Parameters.AddWithValue("@yayin", model.YayinAdi);
            cmd.Parameters.AddWithValue("@dil", model.Dil);
            cmd.Parameters.AddWithValue("@hd", model.HDmi);
            cmd.Parameters.AddWithValue("@radyoid", model.RadyoID);
            cmd.ExecuteNonQuery();
            
            Conn.Close();
        }

        public void Sil(int id)
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Kanallar WHERE KanalID = @ID", Conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        public List<Kanal> Liste()
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Kanallar", Conn);

            SqlDataReader dr = cmd.ExecuteReader();
            
            List<Kanal> kanallar = new List<Kanal>();
            
            while (dr.Read())
            {
                Kanal kanal = new Kanal();

                kanal.KanalID = Convert.ToInt32(dr[0]);
                kanal.KanalAdi = dr.GetString(1);
                kanal.Frekans = Convert.ToInt32(dr[2]);
                kanal.YayinAdi = dr.GetString(3);
                kanal.Dil = dr.GetString(4);
                kanal.HDmi = Convert.ToBoolean(dr[5]);
                kanal.RadyoID = Convert.ToInt32(dr[6]);

                kanallar.Add(kanal);
            }
            Conn.Close();

            return kanallar;
        }
        public int ToplamKanalSayisi()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Kanallar", Conn);
            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            Conn.Close();
            return sonuc;
        }
    }
}
