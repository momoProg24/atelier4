using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace atelier4_____
{
    internal class Mono : IBoite
    {
        public List<string> msg = new List<string>();

        public Mono(string mot)
        {
            msg = mot.Split('n').ToList();
            for (int i = 0; i < msg.Count; i++)
            {
                if (msg[i + 1] != null)
                {
                    if (msg[i].Length > msg[i + 1].Length)
                    {
                        Largeur = msg[i].Length;
                    }
                }
            }
            Hauteur = msg.Count;



        }
        public int Largeur { get; set; }

        public int Hauteur { get; set; }

         class IEnum:IEnumerator<string> // Il va prendre une liste et il va avoir un int Current--MoveNext()
         {
            List<string> list = new List<string>();

            public bool MoveNext()
            {
                if(Current < list.Count + 1)
                {

                    return false;
                }
                return true;

            }
        }
         
      
        public bool EstVide => throw new NotImplementedException();

        public IBoite Cloner()
        {
            throw new NotImplementedException();
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
