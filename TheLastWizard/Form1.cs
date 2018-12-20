using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard {
    public partial class Form1 : Form {
        public Juego juego;
        private Personaje personaje;

        public Form1() {
            InitializeComponent();
            juego = new Juego(this);
            this.personaje = juego.personaje;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // TODO : Hacer los movimientos con un método dentro de la clase Personaje
        private void botonNorte_Click(object sender, EventArgs e) {
            if (juego.mapa.zonaActual.caminableNorte) {
                this.personaje.filaActual -= 1;
                juego.mapa.actualizarZonaActual(juego.mapa.matrizMapa[personaje.filaActual, personaje.columnaActual]);
                juego.buclePrincipal();
            }
            else {
                Juego.agnadirTextoPanelCentral("No se puede continuar en esa dirección.\n");
            }
        }

        private void botonEste_Click(object sender, EventArgs e) {
            if (juego.mapa.zonaActual.caminableEste) {
                this.personaje.columnaActual += 1;
                juego.mapa.actualizarZonaActual(juego.mapa.matrizMapa[personaje.filaActual, personaje.columnaActual]);
                juego.buclePrincipal();
            }
            else {
                Juego.agnadirTextoPanelCentral("No se puede continuar en esa dirección.\n");
            }
        }

        private void botonSur_Click(object sender, EventArgs e) {
            if (juego.mapa.zonaActual.caminableSur) {
                this.personaje.filaActual += 1;
                juego.mapa.actualizarZonaActual(juego.mapa.matrizMapa[personaje.filaActual, personaje.columnaActual]);
                juego.buclePrincipal();
            }
            else {
                Juego.agnadirTextoPanelCentral("No se puede continuar en esa dirección.\n");
            }
        }

        private void botonOeste_Click(object sender, EventArgs e) {
            if (juego.mapa.zonaActual.caminableOeste) {
                this.personaje.columnaActual -= 1;
                juego.mapa.actualizarZonaActual(juego.mapa.matrizMapa[personaje.filaActual, personaje.columnaActual]);
                juego.buclePrincipal();
            }
            else {
                Juego.agnadirTextoPanelCentral("No se puede continuar en esa dirección.\n");
            }
        }

        private void botonLanzarHechizo_Click(object sender, EventArgs e) {
            this.personaje.ultimoBotonAccionPulsado = botonLanzarHechizo;
            this.personaje.lanzarHechizo();
        }

        private void botonAbrir_Click(object sender, EventArgs e) {
            this.personaje.ultimoBotonAccionPulsado = botonAbrir;
            Juego.agnadirTextoPanelCentral("Selecciona lo que deseas abrir\n");
        }
    }
}
