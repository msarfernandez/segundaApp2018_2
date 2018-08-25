using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Veterano : Jugador, IRunable
    {
        public override string correr()
        {
            return "corre re rápido";
        }

        public string Sprintear()
        {
            return "sprintea más rápido";
        }
    }
}
