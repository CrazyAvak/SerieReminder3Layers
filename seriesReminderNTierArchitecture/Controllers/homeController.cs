using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesReminderNTierArchitecture.Controllers
{
    public class homeController
    {
        Logic.Series series;
        public homeController()
        {
            series = new Logic.Series();
        }

        public viewModels.addSerie Create()
        {
            viewModels.addSerie addSerie = new viewModels.addSerie();
            addSerie.ratings = series.getAllRatings();
            addSerie.categories = series.getAllCategories();
            addSerie.statuses = series.getAllStatuses();                                                                            
            return addSerie;
        }

        public void Create(DataModels.Serie serie)
        {

            serie.date_created = DateTime.Now;
            serie.date_updated = DateTime.Now;

            series.createSerie(serie);

        }
        public viewModels.editSerie edit(string serie)
        {
            viewModels.editSerie editSerie = new viewModels.editSerie();
            editSerie.ratings = series.getAllRatings();
            editSerie.categories = series.getAllCategories();
            editSerie.statuses = series.getAllStatuses();
            editSerie.serie = series.getSerie(serie);
            return editSerie;
        }
        public void edit()
        {

        }
        public void delete(int id)
        {
            series.deleteSeries(id);
        }

    }
}
