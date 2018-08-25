using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Profesional : Jugador, IRunable 
    {
        public Especial Especial { get; set; }

        public string Sprintear()
        {
            return "sprintea like a champion";
        }
    }
}
