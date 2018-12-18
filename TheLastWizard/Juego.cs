using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard {
    public class Juego {       
        public RichTextBox panelCentral;
        public Mapa mapa;
        public Personaje personaje;

        public Juego(Form1 pantalla) {
            panelCentral = pantalla.panelCentral;
            this.mapa = new Mapa();
            this.personaje = new Personaje();
            establecerPosicionInicial();
            buclePrincipal();
        }

        private void establecerPosicionInicial() {
            personaje.filaActual = 0;
            personaje.columnaActual = 0;
        }

        public void buclePrincipal() {
            // Se muestra la descripción de la zona actual :
            panelCentral.Text = mapa.matrizMapa[personaje.filaActual, personaje.columnaActual].descripcion;
        }
    }
}
