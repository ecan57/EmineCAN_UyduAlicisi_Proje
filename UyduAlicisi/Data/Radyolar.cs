using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyduAlicisi.Model;

namespace UyduAlicisi.Data
{
    class Radyolar : ICrud<Radyo>
    {
        SqlConnection Conn;

        public Radyolar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }

        public Radyo Bul(int id)
        {
            Conn.Open();

            Radyo radyo = new Radyo();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Radyolar WHERE RadyoID = @ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            radyo.RadyoID = -1;

            if (dr.HasRows)
            {
                radyo.RadyoID = Convert.ToInt32(dr[0]);
                radyo.RadyoAdi = dr.GetString(1);
                radyo.Frekans = Convert.ToDecimal(dr[2]);
                radyo.Dil = dr.GetString(3);
            }
            Conn.Close();

            return radyo;
        }

        public void Ekle(Radyo model)
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Radyolar VALUES (@ad, @frekans, @dil)", Conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", model.RadyoAdi);
            cmd.Parameters.AddWithValue("@frekans", model.Frekans);
            cmd.Parameters.AddWithValue("@dil", model.Dil);
            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        public void Guncelle(Radyo model)
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Radyolar SET RadyoAdi = @ad, Frekans = @frekans, Dil = @dil WHERE RadyoID = @ID", Conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.RadyoID);
            cmd.Parameters.AddWithValue("@ad", model.RadyoAdi);
            cmd.Parameters.AddWithValue("@frekans", model.Frekans);
            cmd.Parameters.AddWithValue("@dil", model.Dil);
            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        public void Sil(int id)
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Radyolar WHERE RadyoID = @ID", Conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();

            Conn.Close();
        }

        public List<Radyo> Liste()
        {
            Conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Radyolar", Conn);

            SqlDataReader dr = cmd.ExecuteReader();

            List<Radyo> radyolar = new List<Radyo>();

            while (dr.Read())
            {
                Radyo radyo = new Radyo();

                radyo.RadyoID = Convert.ToInt32(dr[0]);
                radyo.RadyoAdi = dr.GetString(1);
                radyo.Frekans = Convert.ToDecimal(dr[2]);
                radyo.Dil = dr.GetString(3);

                radyolar.Add(radyo);
            }
            Conn.Close();

            return radyolar;
        }
        public int ToplamRadyoSayisi()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Radyolar", Conn);
            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            Conn.Close();
            return sonuc;
        }
    }
}
