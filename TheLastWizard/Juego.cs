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
        public Form1 pantalla;

        public Juego(Form1 pantalla) {
            panelCentral = pantalla.panelCentral;
            this.pantalla = pantalla;
            panelElementosEntorno = pantalla.flowLayoutPanelElementosEntorno;
            this.mapa = new Mapa(this);
            this.personaje = new Personaje(this, pantalla);
            this.mapa.zonaActual = mapa.matrizMapa[personaje.filaActual, personaje.columnaActual];
            establecerPosicionInicial();
            buclePrincipal();
        }

        private void establecerPosicionInicial() {
            personaje.filaActual = 0;
            personaje.columnaActual = 0;
        }

        public void buclePrincipal() {
            // Se limpian los botones de la zona anterior :
            panelElementosEntorno.Controls.Clear();
            // Se muestra la descripción de la zona actual :
            panelCentral.Text = mapa.zonaActual.descripcion;
            if (mapa.zonaActual.descripcionEncuentroActivada) {
                panelCentral.AppendText(mapa.zonaActual.descripcionEncuentro);
            }
            // Se comprueba si hay enemigo vivo en la zona para asignarlo como enemigo actual:
            if (mapa.zonaActual.tieneEnemigo()) {
                personaje.enemigoActual = mapa.zonaActual.obtenerEnemigo();
            }
            // Se muestran los botones de elementos interactuables de la zona actual:
            foreach(ElementoEntorno elementoEntorno in mapa.zonaActual.listaElementosEntorno) {            
                panelElementosEntorno.Controls.Add(elementoEntorno.boton);
            }
        }

        public static void agnadirTextoPanelCentral(String texto) {
            panelCentral.AppendText(texto);
        }

        public void comprobarTurnoEnemigo() {
            // Se comprueba si está en un encuentro para que el enemigo realice su turno:
            if (personaje.enemigoActual != null) {
                personaje.enemigoActual.realizarTurno();
            }
        }
    }
}
