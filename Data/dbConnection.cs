using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{    
    public class dbConnection
    {
        MySqlConnection conn;
        public dbConnection()
        {
            string connectionString = "Server=localhost;Database=seriesreminder;Uid=root;Pwd=;";
            conn = new MySqlConnection(connectionString);
        }



        public DataTable getAllSeries(string status)
        {
            DataTable table = new DataTable();

            try
            {

                string query = "SELECT idSeries,Name, Season, Episode, categorie.serieCategorie , status.serieStatus, rating.Rating " +
                            "FROM `series` INNER JOIN rating ON series.Rating_idRating = rating.idRating INNER JOIN categorie ON series.Categorie_idType = categorie.idType INNER JOIN status ON series.Status_idStatus = status.idStatus" +
                            " WHERE status.serieStatus = '" + status + "'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;

            }
            catch(MySqlException e)
            {
                throw;
            }
        }
        public DataTable getSerie(int id)
        {
            DataTable table = new DataTable();

            try
            {

                string query = "SELECT idSeries,Name, Season, Episode, categorie.serieCategorie , status.serieStatus, rating.Rating " +
                            "FROM `series` INNER JOIN rating ON series.Rating_idRating = rating.idRating INNER JOIN categorie ON series.Categorie_idType = categorie.idType INNER JOIN status ON series.Status_idStatus = status.idStatus" +
                            " WHERE idSeries = '" + id + "'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;

            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        public DataTable getAllStatuses()
        {
            DataTable table = new DataTable();

            try
            {

                string query = "SELECT * FROM status";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;

            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        public DataTable getAllCategories()
        {
            DataTable table = new DataTable();

            try
            {

                string query = "SELECT * FROM categorie";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;

            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        public DataTable getAllRatings()
        {
            DataTable table = new DataTable();

            try
            {

                string query = "SELECT * FROM rating";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;

            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        public void createSerie(string Name, int Season, int Episode, DateTime Updated, DateTime Created, int idType, int idRating, int idStatus)
        {
            string query = "INSERT into series(Name, Season, Episode,Date_created, date_updated, Categorie_idType, Rating_idRating, Status_idStatus) " +
                    "values('" + Name + "','" + Season + "','" + Episode + "','" + Updated.ToString("yyyy-MM-dd H:mm:ss") + "','" +
                    Created.ToString("yyyy-MM-dd H:mm:ss") + "','" + idType + "','" + idRating + "','" + idStatus + "');";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch(MySqlException e)
            {

            }
        }




        public DataTable getQuery(string query)
        {
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                conn.Close();
                return table;
            }
            catch(MySqlException e)
            {
                throw;
            }
        }
        public void insert(string query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
