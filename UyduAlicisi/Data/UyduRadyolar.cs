using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyduAlicisi.Model;

namespace UyduAlicisi.Data
{
    class UyduRadyolar
    {
        SqlConnection Conn;
        public UyduRadyolar(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public UyduRadyo Bul(int id)
        {
            Conn.Open();
            UyduRadyo uyduRadyo = new UyduRadyo();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UyduRadyo WHERE UyduRadyoID = @ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            uyduRadyo.UyduRadyoID = -1;
            if (dr.HasRows)
            {
                uyduRadyo.UyduRadyoID = Convert.ToInt32(dr[0]);
                uyduRadyo.UyduID = Convert.ToInt32(dr[1]);
                uyduRadyo.RadyoID = Convert.ToInt32(dr[2]);
            }
            Conn.Close();
            return uyduRadyo;
        }
        public void Ekle(UyduRadyo model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO UyduRadyo VALUES (@uyduId, @radyoId)", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uyduId", model.UyduID);
            cmd.Parameters.AddWithValue("@radyoId", model.RadyoID);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void Guncelle(UyduRadyo model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UyduRadyo SET UyduID = @uyduId, RadyoID = @radyoId WHERE UyduRadyoID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.UyduRadyoID);
            cmd.Parameters.AddWithValue("@uyduId", model.UyduID);
            cmd.Parameters.AddWithValue("@radyoId", model.RadyoID);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public List<UyduRadyo> Liste()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UyduRadyo", Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<UyduRadyo> uyduRadyolar = new List<UyduRadyo>();
            while (dr.Read())
            {
                UyduRadyo uyduRadyo = new UyduRadyo();
                uyduRadyo.UyduRadyoID = Convert.ToInt32(dr[0]);
                uyduRadyo.UyduID = Convert.ToInt32(dr[1]);
                uyduRadyo.RadyoID = Convert.ToInt32(dr[2]);
                uyduRadyolar.Add(uyduRadyo);
            }
            Conn.Close();
            return uyduRadyolar;
        }
        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UyduRadyo WHERE UyduRadyoID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
