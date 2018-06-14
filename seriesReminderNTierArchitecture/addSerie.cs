using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seriesReminderNTierArchitecture
{
    public partial class addSerie : Form
    {
        Logic.Series Series;
        Controllers.homeController homeController;
        viewModels.addSerie model;

        public addSerie()
        {
            InitializeComponent();
            homeController = new Controllers.homeController();
            model = homeController.Create();
            populateCategories();
            populateRating();
            populateStatus();
        }        

        private void populateCategories()
        {
            foreach (var item in model.categories)
            {
                cmbCategorie.Items.Add(item.serieCategorie);
            }
            cmbCategorie.SelectedIndex = 0;
        }

        private void populateStatus()
        {
            foreach (var item in model.statuses)
            {
                cmbStatus.Items.Add(item.serieStatus);
            }
            cmbStatus.SelectedIndex = 0;
        }
        private void populateRating()
        {
            foreach (var item in model.ratings)
            {
                cmbRating.Items.Add(item.Rating);
            }
            cmbRating.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataModels.Serie serie = new DataModels.Serie();
            serie.Name = tbName.Text;
            serie.Episode = Convert.ToInt32(numericUpDownEpisode.Value);
            serie.Season = Convert.ToInt32(numericUpDownSeason.Value);
            serie.Categorie_idType = cmbCategorie.SelectedIndex + 1;
            serie.Rating_idRating = cmbRating.SelectedIndex + 1;
            serie.Status_idStatus = cmbStatus.SelectedIndex + 1;
            homeController.Create(serie);
            Close();
        }
    }
}
