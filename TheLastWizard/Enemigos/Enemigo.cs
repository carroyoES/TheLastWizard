using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLastWizard.Objetos;

namespace TheLastWizard.Enemigos {
    public class Enemigo : ElementoEntorno {
        public int reflejos;
        public int puntosVida;
        public int puntosArmadura;
        public int fuerza;
        public bool vivo;
        public Inventario inventario;

        // Los items extra son para añadirlos al inventario base de cada enemigo
        public Enemigo(Juego juego, Item[] itemsExtra) : base(juego) {
            inventario = new Inventario(new List<Item>());
            foreach (Item item in itemsExtra) {
                inventario.itemsEnPosesion.Add(item);
            }
            inicializarBoton();
        }

        public void inicializarBoton() {
            boton = new Button();
            boton.BackColor = Color.Green;
            boton.Text = nombre;
            boton.ForeColor = Color.White;
            boton.AutoSize = true;
            boton.Click += (s, e) => {
                // Si lo último que ha hecho el jugador ha sido pulsar lanzar hechizo:
                if (juego.personaje.ultimoBotonAccionPulsado == juego.pantalla.botonLanzarHechizo) {
                    if (juego.personaje.hechizoCargado.necesitaObjetivo) {
                        juego.personaje.hechizoCargado.lanzar(this);
                    }
                }
                else if(juego.personaje.ultimoBotonAccionPulsado == juego.pantalla.botonSaquear) {
                    // si el enemigo está muerto:
                    juego.personaje.saquear(this);
                    juego.personaje.ultimoBotonAccionPulsado = null;
                }
            };
        }

        public bool esquivar(int dificultad) {
            if (Dados.dosDeSeis() + this.reflejos >= dificultad) {
                return true;
            }
            return false;
        }

        public void recibirDagno(int dagno) {
            if (puntosArmadura < dagno) {
                puntosVida -= (dagno - puntosArmadura);
                Juego.agnadirTextoPanelCentral(nombre + " recibe " + (dagno - puntosArmadura) + " puntos de daño!\n");
                // Se comprueba si muere
                if (puntosVida <= 0) {
                    Juego.agnadirTextoPanelCentral(nombre + " ha sido derrotado!\n");
                    procesarDerrota();
                }
            }
            else {
                Juego.agnadirTextoPanelCentral(nombre + " bloquea todo el daño!\n");
            }
        }

        public void procesarDerrota() {
            vivo = false;
            boton.Text = "Cadáver de " + nombre;
            nombre = "Cadáver de " + nombre;
            juego.mapa.zonaActual.descripcionEncuentroActivada = false;
            juego.personaje.enemigoActual = null;
        }

        public virtual void realizarTurno() {}
    }
}
