using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalHeritageEF.Models
{
    public class VoitureB2:VehiculeB2
    {
        public string Couleur { get; set; }
        public int NbrPassagers { get; set; }
    }
}
