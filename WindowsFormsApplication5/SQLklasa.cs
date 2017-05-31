using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public class SQLklasa:Interfejs
    {
        SqlConnection con = Konekcija.KonekcioniString();

        public void InsertGrupa(Grupa g)
        {
            string sql = "Insert into Grupa (Sifra,Naziv,Opis,Aktivno,TipGrupeID) values (@Sifra,@Naziv,@Opis,@Aktivno,@TipGrupeID)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Sifra", g.Sifra);
            cmd.Parameters.AddWithValue("@Naziv", g.Naziv);
            cmd.Parameters.AddWithValue("@Opis", g.Opis);
            cmd.Parameters.AddWithValue("@Aktivno", g.Aktivno);
            cmd.Parameters.AddWithValue("@TipGrupeID", g.TipGrupeID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Grupa> IscitajGrupe()
        {
            List<Grupa> grupe = new List<Grupa>();
            string sql = "Select Grupa.GrupaID,Grupa.Sifra,Grupa.Naziv,Grupa.Opis,Grupa.Aktivno,Grupa.TipGrupeID,TipGrupe.Naziv as Tip from Grupa inner join TipGrupe on Grupa.TipGrupeID=TipGrupe.TipGrupeID";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Grupa g = new Grupa();
                    g.GrupaID = int.Parse(reader["GrupaID"].ToString());
                    g.Sifra = reader["Sifra"].ToString();
                    g.Naziv = reader["Naziv"].ToString();
                    g.Opis = reader["Opis"].ToString();
                    g.Aktivno = bool.Parse(reader["Aktivno"].ToString());
                    g.NazivTipa = reader["Tip"].ToString();
                    grupe.Add(g);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return grupe;
        }
    }
}
