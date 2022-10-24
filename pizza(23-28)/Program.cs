using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pizza_23_28_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "pizza";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            int dv = Convert.ToInt32(Console.ReadLine());
            switch (dv)
            {
                case 23:
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT futar.fnev, SUM(rendeles.razon)  FROM futar JOIN rendeles USING(fazon) GROUP BY futar.fnev";

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int fazon = dr.GetInt32("fazon");
                                string fnev = dr.GetString("fnev");

                            }
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                    break;

                case 24:
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT pizza.nev, SUM(tetel.db) FROM `pizza`, `tetel` WHERE tetel.pazon=pizza.pazon GROUP BY pnev ORDER BY SUM(tetel.db) DESC;";

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int pnev = dr.GetInt32("pnev");
                                string db = dr.GetString("db");

                            }
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                    break;

                case 25:
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT vevo.vnev, SUM(pizza.par * tetel.db) FROM vevo JOIN rendeles USING(vazon) JOIN tetel USING(razon) JOIN pizza USING(pazon) GROUP BY vevo.vnev ORDER BY SUM(pizza.par*tetel.db) DESC;";

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int vnev = dr.GetInt32("vazon");
                                string db = dr.GetString("pazon");

                            }
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                    break;

                case 26:
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT pizza.pnev, pizza.par AS ár FROM pizza GROUP BY pizza.par DESC LIMIT 1;";

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int pnev = dr.GetInt32("pazon");
                                string par = dr.GetString("pazon");

                            }
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                    break;

                case 27:
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT futar.fnev, SUM(tetel.db) FROM futar JOIN rendeles USING(fazon) JOIN tetel USING(razon) GROUP BY futar.fnev ORDER BY SUM(tetel.db) DESC LIMIT 1;";

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int vnev = dr.GetInt32("vazon");
                                string db = dr.GetString("tetel");

                            }
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                    break;

                case 28:
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT vevo.vnev, SUM(tetel.db) FROM vevo JOIN rendeles USING(vazon) JOIN tetel USING(razon) GROUP BY vevo.vnev ORDER BY SUM(tetel.db) DESC LIMIT 1;";

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int vnev = dr.GetInt32("vazon");
                                string db = dr.GetString("tetel");

                            }
                        }
                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                    break;

                
            }



            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
