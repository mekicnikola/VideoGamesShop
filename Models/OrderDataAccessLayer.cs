using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjekatNapredniWeb.Models
{
    public class OrderDataAccessLayer
    {
        public IEnumerable<Order> PrikazSvihPorudzbina()
        {
            List<Order> listaPorudzbina = new List<Order>();
            List<Item> listaItema = new List<Item>();
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda1 = new SqlCommand("SELECT OrderID, ImePrezime, Adresa, DatumIzdavanja, Suma FROM \"Order\"", konekcija);
                    Order order = null;
                    using (SqlDataReader reader = komanda1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            order = new Order();
                            order.Id= Convert.ToInt32(reader["OrderID"]);
                            order.ImePrezime= reader["ImePrezime"].ToString();
                            order.Adresa = reader["Adresa"].ToString();
                            order.DatumIzdavanja = (DateTime)reader["DatumIzdavanja"];
                            order.Suma = Convert.ToSingle(reader["Suma"]);

                            listaPorudzbina.Add(order);
                        }
                    }

                                     
                }
            }
            catch (Exception)
            {
                //todo
            }
            return listaPorudzbina;
        }

        public IEnumerable<Item> PrikazSvihItema()
        {
            List<Item> listaItema = new List<Item>();
            SqlConnection konekcija = new SqlConnection();
            konekcija.ConnectionString = Startup.ConnectionString;
            try
            {
                using (konekcija)
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("SELECT ItemID, OrderID, ProizvodID, Kolicina FROM Item ", konekcija);
                    Item item = null;

                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            item = new Item();
                            item.Id = Convert.ToInt32(reader["ItemID"]);
                            item.Order = new Order
                            {
                                Id = Convert.ToInt32(reader["OrderID"])
                             };
                        item.Proizvod = new Proizvod
                        {
                            Id = Convert.ToInt32(reader["ProizvodID"])
                           };
                    item.Kolicina = Convert.ToInt32(reader["Kolicina"]);


                            listaItema.Add(item);
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
            return listaItema;
        }

        }
}
