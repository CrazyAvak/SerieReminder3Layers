using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesReminderNTierArchitecture.viewModels
{
    public class addSerie
    {
        public List<DataModels.categorie> categories { get; set; }
        public List<DataModels.status> statuses { get; set; }
        public List<DataModels.rating> ratings { get; set; }

    }

}
