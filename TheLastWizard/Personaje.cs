using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLastWizard.Enemigos;
using TheLastWizard.Magia;
using TheLastWizard.Objetos;

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
        public Inventario inventario;

        public Personaje(Juego juego, Form1 pantalla) {
            this.juego = juego;
            this.pantalla = pantalla;
            this.puntosVida = 10;
            this.reflejos = 5;
            this.puntosArmadura = 2;
            this.enemigoActual = null;
            this.inventario = new Inventario(new List<Item>());
        }

        public void lanzarHechizo() {
            String textoHechizo = pantalla.textBoxHechizo.Text;
            // TODO : determinar el hechizo con un método static de Hechizo que recorra un array con todos los hechizos
            if (textoHechizo.Equals("f")) { // Flama Aeon
                hechizoCargado = new BolaDeFuego(juego);            
            }
            else {
                Juego.agnadirTextoPanelCentral("Tú: ¡" + textoHechizo.ToUpper() + "!\n" + "Tus palabras no parecen surtir ningún efecto mágico\n");
                juego.comprobarTurnoEnemigo();
            }
        }

        public void procesarDerrota() {
            Juego.agnadirTextoPanelCentral("Has sido derrotado!\n");
        }

        public void saquear(ElementoEntorno elementoEntorno) {
            // Si está saqueando a un enemigo:
            if (elementoEntorno is Enemigo) {
                if (!(elementoEntorno as Enemigo).vivo) {                  
                    Juego.agnadirTextoPanelCentral(elementoEntorno.nombre + " tiene:\n");
                    foreach (Item item in (elementoEntorno as Enemigo).inventario.itemsEnPosesion) {
                        pantalla.flowLayoutPanelSaqueo.Controls.Add(item.boton);
                    }
                    pantalla.flowLayoutPanelSaqueo.Visible = true;
                }
                // TODO : si está vivo
            }
        }

        public void agnadirAInventario(Item item) {
            inventario.itemsEnPosesion.Add(item);
        }
    }
}
