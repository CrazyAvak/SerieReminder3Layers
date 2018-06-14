using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesReminderNTierArchitecture.viewModels
{
    public class editSerie
    {
        public DataModels.Serie serie { get; set; }
        public List<DataModels.categorie> categories { get; set; }
        public List<DataModels.rating> ratings { get; set; }
        public List<DataModels.status> statuses { get; set; }
    }
}
