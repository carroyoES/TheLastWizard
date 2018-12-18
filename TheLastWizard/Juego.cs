using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard {
    class Juego {       
        public RichTextBox panelCentral;
        public Mapa mapa;

        public Juego(Form1 pantalla) {
            panelCentral = pantalla.panelCentral;
            this.mapa = new Mapa();
            buclePrincipal();
        }

        private void buclePrincipal() {
            // Se muestra la descripción de la zona actual
            panelCentral.Text = mapa.matrizMapa[0, 0].descripcion;
        }
    }
}
