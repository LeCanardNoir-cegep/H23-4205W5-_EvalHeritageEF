﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvalHeritageEF.Models
{
    public class VoitureD:VehiculeD
    {
        public string Couleur { get; set; }
        public int NbrPassagers { get; set; }
        public int NbrVitesses { get; set; }
        public string Modele { get; set; }
        public bool CameraRecule { get; set; }
        public bool BoiteManuelle { get; set; }
    }
}
