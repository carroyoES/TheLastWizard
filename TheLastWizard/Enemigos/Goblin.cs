using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard.Enemigos {
    public class Goblin : Enemigo {

        public Goblin(Juego juego) {
            this.juego = juego;
            nombre = "Goblin";
            reflejos = 3;
            puntosVida = 6;
            puntosArmadura = 2;
            fuerza = 2;
            vivo = true;
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
            };
        }

        public override void realizarTurno() {
            atacar();
        }

        public void atacar() {
            Juego.agnadirTextoPanelCentral("El Goblin te ataca con su espada\n");
            if (Dados.dosDeSeis() + fuerza >= juego.personaje.reflejos) {
                realizarDagno();
            }
            else {
                Juego.agnadirTextoPanelCentral(this.nombre + " no logra alcanzarte.\n");
            }
        }

        public void realizarDagno() {
            Personaje personaje = juego.personaje;
            int dagno = Dados.unoDeSeis();
            if (personaje.puntosArmadura < dagno) {
                puntosVida -= (dagno - personaje.puntosArmadura);
                Juego.agnadirTextoPanelCentral("Recibes " + (dagno - personaje.puntosArmadura) + " puntos de daño!\n");
                // Se comprueba si muere el personaje
                if (personaje.puntosVida <= 0) {
                    personaje.procesarDerrota();
                }
            }
            else {
                Juego.agnadirTextoPanelCentral("Has bloqueado todo el daño!\n");
            }
        }

    }
}
