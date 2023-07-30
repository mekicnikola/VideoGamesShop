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
                    SqlCommand komanda = new SqlCommand("SELECT id, naziv, cena, izdavac, zanr, platforma, datumIzlaska,slika FROM Proizvod", konekcija);
                    Proizvod proizvod = null;
                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proizvod = new Proizvod();
                            proizvod.Id = Convert.ToInt32(reader["id"]);
                            proizvod.Naziv = reader["naziv"].ToString();
                            proizvod.Cena = Convert.ToSingle(reader["cena"]);
                            proizvod.Izdavac = reader["izdavac"].ToString();
                            proizvod.Zanr = reader["zanr"].ToString();
                            proizvod.Platforma = reader["platforma"].ToString();
                            proizvod.DatumIzlaska = (DateTime)reader["datumIzlaska"];
                            proizvod.Slika = reader["slika"].ToString();
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
                    SqlCommand komanda = new SqlCommand("INSERT INTO Proizvod(Naziv, Cena, Izdavac, Zanr, Platforma, DatumIzlaska, Slika) VALUES(@naz, @cena, @izd, @zanr, @plat, @dat,@slika);", konekcija);
                    SqlParameter nazivParam = new SqlParameter("@naz", SqlDbType.NVarChar);
                    nazivParam.Value = proizvod.Naziv;
                    SqlParameter cenaParam = new SqlParameter("@cena", SqlDbType.Float);
                    cenaParam.Value = proizvod.Cena;
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
                    komanda.Parameters.Add(cenaParam);
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
                            proizvod.Cena = Convert.ToSingle(reader["cena"]);
                            proizvod.Izdavac = reader["izdavac"].ToString();
                            proizvod.Zanr = reader["zanr"].ToString();
                            proizvod.Platforma = reader["platforma"].ToString();
                            proizvod.DatumIzlaska = (DateTime)reader["datumIzlaska"];
                            proizvod.Slika = reader["slika"].ToString();
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
                    SqlCommand komanda = new SqlCommand("UPDATE Proizvod SET Naziv=@naz, Cena=@cena, Izdavac=@izd, Zanr=@zanr, Platforma=@plat, DatumIzlaska=@dat, Slika=@slika WHERE ID=@id;", konekcija);

                    SqlParameter idParam = new SqlParameter("@id", SqlDbType.NVarChar);
                    idParam.Value = proizvod.Id;

                    SqlParameter nazivParam = new SqlParameter("@naz", SqlDbType.NVarChar);
                    nazivParam.Value = proizvod.Naziv;
                    SqlParameter cenaParam = new SqlParameter("@cena", SqlDbType.Float);
                    cenaParam.Value = proizvod.Cena;
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
                    komanda.Parameters.Add(cenaParam);
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

        public void NapraviOrder(List<Item> items, Order order)
        {

            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda1 = new SqlCommand("INSERT INTO \"Order\"(ImePrezime, Adresa, DatumIzdavanja, Suma) VALUES(@ime, @adresa, @dat,@suma); SELECT SCOPE_IDENTITY()", konekcija);

                    SqlParameter imeParam = new SqlParameter("@ime", SqlDbType.NVarChar);
                    imeParam.Value = order.ImePrezime;

                    SqlParameter adresaParam = new SqlParameter("@adresa", SqlDbType.NVarChar);
                    adresaParam.Value = order.Adresa;

                    SqlParameter datumParam = new SqlParameter("@dat", SqlDbType.DateTime);
                    datumParam.Value = DateTime.Now;

                    SqlParameter sumaParam = new SqlParameter("@suma", SqlDbType.Float);
                    sumaParam.Value = order.Suma;


                    komanda1.Parameters.Add(imeParam);
                    komanda1.Parameters.Add(adresaParam);
                    komanda1.Parameters.Add(datumParam);
                    komanda1.Parameters.Add(sumaParam);

                    //komanda1.ExecuteNonQuery();

                    int orderID = Convert.ToInt32(komanda1.ExecuteScalar());

                    foreach (Item i in items)
                    {
                        
                        SqlCommand komanda2 = new SqlCommand("INSERT INTO Item(OrderID,ProizvodID, Kolicina) VALUES(@orderID, @prID, @kol);", konekcija);

                        SqlParameter narIDParam = new SqlParameter("@orderID", SqlDbType.Int);
                        narIDParam.Value = orderID;

                        SqlParameter prIDParam = new SqlParameter("@prID", SqlDbType.Int);
                        prIDParam.Value = i.Proizvod.Id;

                        SqlParameter kolicinaParam = new SqlParameter("@kol", SqlDbType.Int);
                        kolicinaParam.Value = i.Kolicina;

                        komanda2.Parameters.Add(narIDParam);
                        komanda2.Parameters.Add(prIDParam);
                        komanda2.Parameters.Add(kolicinaParam);

                        komanda2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception err)
            {
                // Handle an error by displaying the information.
            }
        }

    }
}
