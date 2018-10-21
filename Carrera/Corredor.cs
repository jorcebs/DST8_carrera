using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Corredor
    {
        public int distancia { private set; get; }
        static private Random aleatorio;
        
        public Corredor()
        {
            distancia = 0;
            aleatorio = new Random();
        }

        public void Correr()
        {
            switch(aleatorio.Next(1,7))
            {
                case 1:
                    distancia += 3;
                    break;
                case 2: case 3:
                    distancia += 1;
                    break;
                default:
                    distancia += 2;
                    break;
            }
        }
    }
}