using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLastWizard.Magia;

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
            Hechizo hechizo; // TODO : determinar el hechizo con un método static de Hechizo que recorra un array con todos los hechizos
            if (textoHechizo.Equals("Flama Aeon")) {
                hechizo = new BolaDeFuego();
                pantalla.panelCentral.AppendText(hechizo.descripcion); 
                // TODO : poner la descripción del hechizo en cuestión. Y si no hay enemigo se describe de forma distinta etc
            }
            else {
                pantalla.panelCentral.AppendText("Hechizo desconocido");
            }
        }
    }
}
