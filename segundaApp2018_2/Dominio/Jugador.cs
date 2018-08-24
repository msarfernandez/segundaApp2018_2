using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador
    {
        //un atributo/property todo en uno.
        //como hacemos directamente la property, va con mayus-
        public string Nombre { get; set; }
        //

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                this.fechaNacimiento = value;
                calcularEdad(21, new DateTime());
            }
        }

        //recuerden que esto es placebo, o sea, no hace nada.
        //como la poción de liquid luck que le dio harry a Ron
        private void calcularEdad(int edad, DateTime fechaNacimiento)
        {
            Edad = edad;
            this.fechaNacimiento = fechaNacimiento;

        }
        //esta es otra property con su atributo que lo genera
        //magicamente.
        public int Edad { get; set; }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value.Length <= 50)
                    apellido = value;
                else
                    throw new Exception();
            }
        }
    }





}

