﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chrysalide : StadeDEvolution
    {
        public override StadeDEvolution DonneTonProchainEtat()
        {
            return new Papillon();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je suis pendu");
            return false;
        }
    }
}