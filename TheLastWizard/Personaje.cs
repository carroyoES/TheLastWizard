using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard {
    public class Personaje {
        public int filaActual;
        public int columnaActual;
        private Form1 pantalla;

        public Personaje(Form1 pantalla) {
            this.pantalla = pantalla;
        }

        public void lanzarHechizo() {
            String textoHechizo = pantalla.textBoxHechizo.Text;
            if (textoHechizo.Equals("Flama Aeon")) {
                pantalla.panelCentral.AppendText("Lanzas una bola de fuego que consume al Goblin"); // TODO : poner la descripción del hechizo en cuestión
            }
            else {
                pantalla.panelCentral.AppendText("Hechizo desconocido");
            }
        }
    }
}
