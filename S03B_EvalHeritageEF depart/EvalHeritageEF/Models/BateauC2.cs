﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalHeritageEF.Models
{
    public class BateauC2:VehiculeC2
    {
        public int NbrVoile { get; set; }
        public string Nom { get; set; }
        public int Longueur { get; set; }
        public bool PiloteAutomatique { get; set; }
        public int NbrMats { get; set; }
    }
}
