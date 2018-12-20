using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLastWizard.Enemigos;
using TheLastWizard.Magia;

namespace TheLastWizard {
    public class Personaje {
        public int filaActual;
        public int columnaActual;
        public int puntosVida;
        public int reflejos;
        public int puntosArmadura;
        public Button ultimoBotonAccionPulsado;
        private Form1 pantalla;
        public Hechizo hechizoCargado;
        public Juego juego;
        public Enemigo enemigoActual; // TODO : List de enemigos

        public Personaje(Juego juego, Form1 pantalla) {
            this.juego = juego;
            this.pantalla = pantalla;
            this.puntosVida = 10;
            this.reflejos = 5;
            this.puntosArmadura = 2;
            this.enemigoActual = null;
        }

        public void lanzarHechizo() {
            String textoHechizo = pantalla.textBoxHechizo.Text;
            // TODO : determinar el hechizo con un método static de Hechizo que recorra un array con todos los hechizos
            if (textoHechizo.Equals("f")) { // Flama Aeon
                hechizoCargado = new BolaDeFuego(juego);            
            }
            else {
                Juego.agnadirTextoPanelCentral("Hechizo desconocido\n");
            }
        }

        public void procesarDerrota() {
            Juego.agnadirTextoPanelCentral("Has sido derrotado!\n");
        }
    }
}
