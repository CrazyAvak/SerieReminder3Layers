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
    public partial class editSerie : Form
    {

        Controllers.homeController homeController;
        viewModels.editSerie model;

        public editSerie(string serie)
        {
            InitializeComponent();
            homeController = new Controllers.homeController();
            model = homeController.edit(serie);
            populateCategories();
            populateRating();
            populateStatus();
            fillFields();
        }


        private void editSerie_Load(object sender, EventArgs e)
        {

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
        private void fillFields()
        {
            tbName.Text = model.serie.Name;
            numericUpDownEpisode.Value = model.serie.Episode;
            numericUpDownSeason.Value = model.serie.Season;
            cmbCategorie.SelectedItem = model.serie.Categorie_Type;
            cmbRating.SelectedItem = model.serie.Rating_Rating;
            cmbStatus.SelectedItem = model.serie.Status_status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeController.delete(model.serie.idSeries);
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
