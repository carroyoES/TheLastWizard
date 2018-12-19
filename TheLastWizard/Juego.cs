using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard {
    public class Juego {       
        public static RichTextBox panelCentral;
        public FlowLayoutPanel panelElementosEntorno;
        public Mapa mapa;
        public Personaje personaje;

        public Juego(Form1 pantalla) {
            panelCentral = pantalla.panelCentral;
            panelElementosEntorno = pantalla.flowLayoutPanelElementosEntorno;
            this.mapa = new Mapa();
            this.personaje = new Personaje(pantalla);
            establecerPosicionInicial();
            buclePrincipal();
        }

        private void establecerPosicionInicial() {
            personaje.filaActual = 0;
            personaje.columnaActual = 0;
        }

        public void buclePrincipal() {
            Zona zonaActual = mapa.matrizMapa[personaje.filaActual, personaje.columnaActual];
            // Se muestra la descripción de la zona actual :
            panelCentral.Text = zonaActual.descripcion;
            // Se muestran los botones de elementos interactuables de la zona actual:
            foreach(ElementoEntorno elementoEntorno in zonaActual.listaElementosEntorno) {            
                panelElementosEntorno.Controls.Add(elementoEntorno.boton);
            }
        }

        public static void agnadirTextoPanelCentral(String texto) {
            panelCentral.AppendText(texto);
        }
    }
}
