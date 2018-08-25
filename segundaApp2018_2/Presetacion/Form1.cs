using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presetacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Habilidad algo = new Habilidad();

            Profesional unPro;
            Jugador unJugador = new Profesional();
            //Si descomento esto falla... por qué era? Te acordás?
            //unJugador = new Veterano();
            unPro = (Profesional)unJugador;
            unJugador = new Amateur();
            Amateur unAmateur;
            Veterano unVeterano;

            //seguimos con mas ejemplos.
            Jugador jugadorDos = new Jugador();
            jugadorDos.Nombre = "Marcos";
            jugadorDos.Apellido = "Rojo";
            jugadorDos.Habilidad = new Habilidad("Lento");
            jugadorDos.FechaNacimiento = new DateTime();

            //MessageBox.Show("la edad es: " + jugadorDos.Edad.ToString());
            //MessageBox.Show(jugadorDos.correr());

            //Profesional profesionalDos = new Profesional();
            //MessageBox.Show(profesionalDos.correr());

            //Veterano veteranoDos = new Veterano();
            //MessageBox.Show(veteranoDos.correr());

            Jugador marcosRojo = new Jugador();
            Profesional leoPonzio = new Profesional();
            Veterano diMaria = new Veterano();
            Amateur ferchuGago = new Amateur();

            //MessageBox.Show("jugador: " + marcosRojo.correr() + "\r\n" +
            //    "profesional: " + leoPonzio.correr() + "\r\n" + 
            //    "veterano: " + diMaria.correr() + "\r\n" + 
            //    "amateur: " + ferchuGago.correr());

            List<Jugador> listaJugadores = new List<Jugador>();
            listaJugadores.Add(marcosRojo);
            listaJugadores.Add(leoPonzio);
            listaJugadores.Add(ferchuGago);
            listaJugadores.Add(diMaria);
            listaJugadores.Add(new Jugador());
            listaJugadores.Add(new Profesional());
            listaJugadores.Add(new Profesional());

            //foreach (var jugador in listaJugadores)
            //{
            //    MessageBox.Show(jugador.correr());
            //}

            IList<IRunable> listaSprinteadores = new List<IRunable>();

            listaSprinteadores.Add(leoPonzio);
            listaSprinteadores.Add(diMaria);
            listaSprinteadores.Add(new Profesional());

            foreach (var item in listaSprinteadores)
            {
                MessageBox.Show(item.Sprintear());
            }

            IRunable nombreAmigo = new Profesional();


            //


        }
    }
}
