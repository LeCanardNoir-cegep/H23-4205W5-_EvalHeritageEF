using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalHeritageEF.Models
{
    public abstract class VehiculeA
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string LicencePlate { get; set; }
        public string Marque { get; set; }
    }
}
