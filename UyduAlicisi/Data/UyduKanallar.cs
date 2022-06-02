using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyduAlicisi.Model;

namespace UyduAlicisi.Data
{
    class UyduKanallar
    {
        SqlConnection Conn;
        public UyduKanallar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public UyduKanal Bul(int id)
        {
            Conn.Open();
            UyduKanal uyduKanal = new UyduKanal();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UyduKanal WHERE UyduKanalID = @ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            uyduKanal.UyduKanalID = -1;
            if (dr.HasRows)
            {
                uyduKanal.UyduKanalID = Convert.ToInt32(dr[0]);
                uyduKanal.UyduID = Convert.ToInt32(dr[1]);
                uyduKanal.KanalID = Convert.ToInt32(dr[2]);
            }
            Conn.Close();
            return uyduKanal;
        }
        public void Ekle(UyduKanal model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UyduKanal VALUES (@uyduId, @kanalId)", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uyduId", model.UyduID);
            cmd.Parameters.AddWithValue("@kanalId", model.KanalID);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void Guncelle(UyduKanal model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UyduKanal SET UyduID = @uyduId, KanalID = @kanalId WHERE UyduRadyoID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.UyduKanalID);
            cmd.Parameters.AddWithValue("@uyduId", model.UyduID);
            cmd.Parameters.AddWithValue("@kanalId", model.KanalID);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public List<UyduKanal> Liste()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UyduKanal", Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<UyduKanal> uyduKanallar = new List<UyduKanal>();
            while (dr.Read())
            {
                UyduKanal uyduKanal = new UyduKanal();
                uyduKanal.UyduID = Convert.ToInt32(dr[0]);
                uyduKanal.UyduKanalID = Convert.ToInt32(dr[2]);
                uyduKanallar.Add(uyduKanal);
            }
            Conn.Close();
            return uyduKanallar;
        }
        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UyduKanal WHERE UyduKanalID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
