﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador : IComparable
    {
        public Habilidad Habilidad { get; set; }

        //un atributo/property todo en uno.
        //como hacemos directamente la property, va con mayus-
        public string Nombre { get; set; }
        //

        //ejemplo de hacer un atributo y la propiedad aparte.
        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {//la propiedad la hacemos aparte si queremos realizar
            //acciones adicionales por ejemplo en el set.
            get { return fechaNacimiento; }
            set
            {
                this.fechaNacimiento = value;
                calcularEdad(21, new DateTime(1980, 6, 6));
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
            {//acá estamos validando, si no nos gusta
                //lanzamos una excepcion.
                if (value.Length <= 50)
                    apellido = value;
                else
                    throw new Exception();
            }
        }


        public virtual string correr()
        {
            return "trota";
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }





}

