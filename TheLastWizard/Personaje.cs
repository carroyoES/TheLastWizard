using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLastWizard.Magia;

namespace TheLastWizard {
    public class Personaje {
        public int filaActual;
        public int columnaActual;
        public Button ultimoBotonAccionPulsado;
        private Form1 pantalla;
        public static Hechizo hechizoCargado;

        public Personaje(Form1 pantalla) {
            this.pantalla = pantalla;
        }

        public void lanzarHechizo() {
            String textoHechizo = pantalla.textBoxHechizo.Text;
            // TODO : determinar el hechizo con un método static de Hechizo que recorra un array con todos los hechizos
            if (textoHechizo.Equals("Flama Aeon")) {
                hechizoCargado = new BolaDeFuego();            
            }
            else {
                Juego.agnadirTextoPanelCentral("Hechizo desconocido\n");
            }
        }
    }
}
