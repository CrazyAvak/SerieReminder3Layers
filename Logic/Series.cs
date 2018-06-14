using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logic
{
    public class Series
    {
        Data.dbConnection db;
        public Series()
        {
            db = new Data.dbConnection();
        }

        public List<DataModels.Serie> getAllSeries(string status)
        {

            List<DataModels.Serie> series = new List<DataModels.Serie>();
            
            foreach (DataRow Dserie in db.getAllSeries(status).Rows)
            {
                DataModels.Serie serie = new DataModels.Serie();
                serie.idSeries = Convert.ToInt32(Dserie["idSeries"]);
                serie.Name = Dserie["Name"].ToString();
                serie.Season = Convert.ToInt32(Dserie["Season"]);
                serie.Episode = Convert.ToInt32(Dserie["episode"]);
                serie.Categorie_Type = Dserie["serieCategorie"].ToString();
                serie.Status_status = Dserie["serieStatus"].ToString();
                serie.Rating_Rating = Dserie["rating"].ToString();
                series.Add(serie);
            }
            return series;   
        }

        public void createSerie(DataModels.Serie serie)
        {            
            db.createSerie(serie.Name,serie.Season,serie.Episode,serie.date_updated,serie.date_created,serie.Categorie_idType,serie.Rating_idRating,serie.Status_idStatus);
        }

        public List<DataModels.status> getAllStatuses()
        {

            List<DataModels.status> statuses = new List<DataModels.status>();
            DataTable table = db.getAllStatuses();
            foreach (DataRow item in table.Rows)
            {
                DataModels.status status = new DataModels.status();
                status.idStatus = Convert.ToInt32(item["idStatus"]);
                status.serieStatus = Convert.ToString(item["serieStatus"]);
                statuses.Add(status);
            }
            return statuses;
        }
        public List<DataModels.categorie> getAllCategories()
        {
            List<DataModels.categorie> categories = new List<DataModels.categorie>();
            DataTable table = db.getAllCategories();
            foreach (DataRow item in table.Rows)
            {
                DataModels.categorie categorie = new DataModels.categorie();
                categorie.idType = Convert.ToInt32(item["idType"]);
                categorie.serieCategorie = Convert.ToString(item["serieCategorie"]);
                categories.Add(categorie);

            }
            return categories;
        }
        public List<DataModels.rating> getAllRatings()
        {
            List<DataModels.rating> ratings = new List<DataModels.rating>();
            DataTable table = db.getAllRatings();
            foreach (DataRow item in table.Rows)
            {
                DataModels.rating rating = new DataModels.rating();
                rating.idRating = Convert.ToInt32(item["idRating"]);
                rating.Rating = Convert.ToInt32(item["Rating"]);
                ratings.Add(rating);
            }
            return ratings;
        }

        public DataModels.Serie getSerie(string serie)
        {
            DataModels.Serie _serie = new DataModels.Serie();
            int id = Convert.ToInt32(serie.Substring(0, serie.IndexOf(" ")) );
            
            foreach (DataRow item in db.getSerie(id).Rows)
            {
                _serie.idSeries = Convert.ToInt32(item["idSeries"]);
                _serie.Name = item["Name"].ToString();
                _serie.Season = Convert.ToInt32(item["Season"]);
                _serie.Episode = Convert.ToInt32(item["Episode"]);
                _serie.Categorie_Type = item["serieCategorie"].ToString();
                _serie.Status_status = item["serieStatus"].ToString();
                _serie.Rating_Rating = item["rating"].ToString();
            }
            return _serie;

        }
        public void deleteSeries(int id)
        {
            string query = "DELETE FROM series WHERE idSeries = " + id + "";
        }

    }
}
