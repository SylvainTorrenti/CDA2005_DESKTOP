﻿using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Employes
{
    class Gardien : ISeDeplacer
    {
        public bool SeDeplacer()
        {
            Console.WriteLine("Je marche");
            return true;
        }
    }
}