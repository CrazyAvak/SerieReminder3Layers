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
    public partial class Form1 : Form
    {
        Logic.Series series;
        Controllers.homeController homeController;

        public Form1()
        {
            InitializeComponent();
            series = new Logic.Series();
            homeController = new Controllers.homeController();
            populateStatus();
            populateSeriesList();   
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addSerie addSerie = new addSerie();

            addSerie.Show();
        }

        private void populateStatus()
        {
            
            foreach (var item in series.getAllStatuses())
            {
                cmbStatus.Items.Add(item.serieStatus);
            }
            cmbStatus.SelectedIndex = 0;
        }

        private void populateSeriesList()
        {
            listSeries.Items.Clear();
            foreach (var series in series.getAllSeries(cmbStatus.Text))
            {
                listSeries.Items.Add(series);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateSeriesList();
        }

        private void listSeries_DoubleClick(object sender, EventArgs e)
        {
            string serie = listSeries.SelectedItem.ToString();
            editSerie editSerie = new editSerie(serie);
            editSerie.Show();
            
        }
    }
}
