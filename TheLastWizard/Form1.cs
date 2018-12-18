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

        private void botonNorte_Click(object sender, EventArgs e) {
            this.personaje.filaActual -= 1;
            juego.buclePrincipal();
        }

        private void botonEste_Click(object sender, EventArgs e) {
            this.personaje.columnaActual += 1;
            juego.buclePrincipal();
        }

        private void botonSur_Click(object sender, EventArgs e) {
            this.personaje.filaActual += 1;
            juego.buclePrincipal();
        }

        private void botonOeste_Click(object sender, EventArgs e) {
            this.personaje.columnaActual -= 1;
            juego.buclePrincipal();
        }

        private void botonLanzarHechizo_Click(object sender, EventArgs e) {
            this.personaje.lanzarHechizo();
        }
    }
}
