﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4_____
{
    public interface IBoite : IEnumerable<string>
    {
        void Redimensionner(int hauteur, int largeur);
        IBoite Cloner();
        IEnumerator<string> GetÉnumérateur();
        int Largeur { get; }
        int Hauteur { get; }
        bool EstVide { get; }
    }
}
