using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Models
{
    public class ProizvodDataAccessLayer
    {
        public IEnumerable<Proizvod> PrikazSvihProizvoda()
        {
            List<Proizvod> listaProizvoda = new List<Proizvod>();
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("SELECT id, naziv, izdavac, zanr, platforma, datumIzlaska FROM Proizvod", konekcija);
                    Proizvod proizvod = null;
                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proizvod = new Proizvod();
                            proizvod.Id = Convert.ToInt32(reader["id"]);
                            proizvod.Naziv = reader["naziv"].ToString();
                            proizvod.Izdavac = reader["izdavac"].ToString();
                            proizvod.Zanr = reader["zanr"].ToString();
                            proizvod.Platforma = reader["platforma"].ToString();
                            proizvod.DatumIzlaska = (DateTime)reader["datumIzlaska"];
                            listaProizvoda.Add(proizvod);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //todo
            }
            return listaProizvoda;
        }

        public void UbaciProizvod(Proizvod proizvod)
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("INSERT INTO Proizvod(Naziv, Izdavac, Zanr, Platforma, DatumIzlaska, Slika) VALUES(@naz, @izd, @zanr, @plat, @dat,@slika);", konekcija);
                    SqlParameter nazivParam = new SqlParameter("@naz", SqlDbType.NVarChar);
                    nazivParam.Value = proizvod.Naziv;
                    SqlParameter izdavacParam = new SqlParameter("@izd", SqlDbType.NVarChar);
                    izdavacParam.Value = proizvod.Izdavac;
                    SqlParameter zanrParam = new SqlParameter("@zanr", SqlDbType.NVarChar);
                    zanrParam.Value = proizvod.Zanr;
                    SqlParameter platformaParam = new SqlParameter("@plat", SqlDbType.NVarChar);
                    platformaParam.Value = proizvod.Platforma;
                    SqlParameter datumParam = new SqlParameter("@dat", SqlDbType.Date);
                    datumParam.Value = proizvod.DatumIzlaska;

                    SqlParameter slikaParam = new SqlParameter("@slika", SqlDbType.NVarChar);
                    slikaParam.Value = proizvod.Slika;

                    komanda.Parameters.Add(nazivParam);
                    komanda.Parameters.Add(izdavacParam);
                    komanda.Parameters.Add(zanrParam);
                    komanda.Parameters.Add(platformaParam);
                    komanda.Parameters.Add(datumParam);
                    komanda.Parameters.Add(slikaParam);
                    komanda.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                // Handle an error by displaying the information.
            }
        }

        public Proizvod PodaciOProizvodu(int? id)
        {
            Proizvod proizvod = new Proizvod();

            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    string upit = "SELECT * FROM Proizvod WHERE ID = " + id;
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Proizvod WHERE ID = " + id, konekcija);

                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proizvod = new Proizvod();
                            proizvod.Id = Convert.ToInt32(reader["id"]);
                            proizvod.Naziv = reader["naziv"].ToString();
                            proizvod.Izdavac = reader["izdavac"].ToString();
                            proizvod.Zanr = reader["zanr"].ToString();
                            proizvod.Platforma = reader["platforma"].ToString();
                            proizvod.DatumIzlaska = (DateTime)reader["datumIzlaska"];
                        }
                    }


                }
            }
            catch (Exception)
            {
                //todo
            }
            return proizvod;
        }

        public void IzmeniProizvod(Proizvod proizvod)
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("UPDATE Proizvod SET Naziv=@naz, Izdavac=@izd, Zanr=@zanr, Platforma=@plat, DatumIzlaska=@dat, Slika=@slika WHERE ID=@id;", konekcija);

                    SqlParameter idParam = new SqlParameter("@id", SqlDbType.NVarChar);
                    idParam.Value = proizvod.Id;

                    SqlParameter nazivParam = new SqlParameter("@naz", SqlDbType.NVarChar);
                    nazivParam.Value = proizvod.Naziv;
                    SqlParameter izdavacParam = new SqlParameter("@izd", SqlDbType.NVarChar);
                    izdavacParam.Value = proizvod.Izdavac;
                    SqlParameter zanrParam = new SqlParameter("@zanr", SqlDbType.NVarChar);
                    zanrParam.Value = proizvod.Zanr;
                    SqlParameter platformaParam = new SqlParameter("@plat", SqlDbType.NVarChar);
                    platformaParam.Value = proizvod.Platforma;
                    SqlParameter datumParam = new SqlParameter("@dat", SqlDbType.Date);
                    datumParam.Value = proizvod.DatumIzlaska;

                    SqlParameter slikaParam = new SqlParameter("@slika", SqlDbType.NVarChar);
                    slikaParam.Value = proizvod.Slika;

                    komanda.Parameters.Add(idParam);
                    komanda.Parameters.Add(nazivParam);
                    komanda.Parameters.Add(izdavacParam);
                    komanda.Parameters.Add(zanrParam);
                    komanda.Parameters.Add(platformaParam);
                    komanda.Parameters.Add(datumParam);
                    komanda.Parameters.Add(slikaParam);
                    komanda.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                // Handle an error by displaying the information.
            }
        }

        public void ObrisiProizvod(int? id)
        {
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("DELETE Proizvod WHERE ID=@id;", konekcija);

                    komanda.Parameters.AddWithValue("@id", id);

                    komanda.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                // Handle an error by displaying the information.
            }
        }
    }
}
