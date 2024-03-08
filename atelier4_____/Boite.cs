using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4_____
{
    internal class Boite : IBoite
    {

        IBoite boiteMain;
        public Boite(IBoite boite)
        {
        
        }

        public Boite(string s)
        {
            boiteMain = new Mono(s);
        }
        public int Largeur => throw new NotImplementedException();

        public int Hauteur => throw new NotImplementedException();

        public bool EstVide => throw new NotImplementedException();

        public IBoite Cloner()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetÉnumérateur()
        {
            throw new NotImplementedException();
        }

        public void Redimensionner(int hauteur, int largeur)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
