using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvMaker.Models.Enums {
    public enum SoldieringStatusEnum:byte {
        None = 0,
        Done = 1,
        Deferment = 2,
        Exempted = 3,
    }
}
