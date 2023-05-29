using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvMaker.Models.General {
    public class ExperianceModels {
        public Guid Id { get; set; }
        public string ExperianceName { get; set; }
        public string WorkPlaceName { get; set; }
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkEndDate { get; set; }
        public string WorkExperiance { get; set; }

    }
}
