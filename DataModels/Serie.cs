using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Serie
    {
        public int idSeries { get; set; }
        public string Name { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        
        //foreign keys
        public int Categorie_idType { get; set; }
        public string Categorie_Type { get; set; }

        public int Rating_idRating { get; set; }
        public string Rating_Rating { get; set; }

        public int Status_idStatus { get; set; }
        public string Status_status { get; set; }

        public override string ToString()
        {
            string serie = "";
            serie = serie = idSeries + " ," + Name + ", Season:" + Season + ", Episode:" + Episode + ", Categorie:" + Categorie_Type + ", Status:" + Status_status + ", Rating:" + Rating_Rating;
            return serie;
        }
    }
}
