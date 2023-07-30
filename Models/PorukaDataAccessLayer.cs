using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Models
{
    public class PorukaDataAccessLayer
    {
        public void KreirajPoruku(Poruka poruka)
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("INSERT INTO Poruka(ImePrezime, Datum, Poruka, Email) VALUES(@ime, @dat, @por, @email);", konekcija);
                    
                    SqlParameter imeParam = new SqlParameter("@ime", SqlDbType.NVarChar);
                    imeParam.Value = poruka.ImePrezime;
                    
                    SqlParameter datumParam = new SqlParameter("@dat", SqlDbType.Date);
                    datumParam.Value = DateTime.Now;

                    SqlParameter porukaParam = new SqlParameter("@por", SqlDbType.NVarChar);
                    porukaParam.Value = poruka.PorukaSadrzaj;

                    SqlParameter emailParam = new SqlParameter("@email", SqlDbType.NVarChar);
                    emailParam.Value = poruka.Email;


                    komanda.Parameters.Add(imeParam);
                    komanda.Parameters.Add(datumParam);
                    komanda.Parameters.Add(porukaParam);
                    komanda.Parameters.Add(emailParam);
                    komanda.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                // Handle an error by displaying the information.
            }
        }

        public IEnumerable<Poruka> PrikazSvihPoruka()
        {
            List<Poruka> listaPoruka = new List<Poruka>();
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("SELECT PorukaID, ImePrezime, Datum, Poruka, Email FROM Poruka", konekcija);
                    Poruka poruka = null;
                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            poruka = new Poruka();
                            poruka.Id = Convert.ToInt32(reader["PorukaID"]);
                            poruka.ImePrezime = reader["ImePrezime"].ToString();
                           
                            poruka.Datum = (DateTime)reader["Datum"];
                            poruka.PorukaSadrzaj = reader["Poruka"].ToString();
                            poruka.Email = reader["Email"].ToString();
                            listaPoruka.Add(poruka);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //todo
            }
            return listaPoruka;
        }
    }
}
