using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Enemigos {
    public class Enemigo : ElementoEntorno {
        public int reflejos;
        public int puntosVida;
        public int puntosArmadura;
        public bool vivo;

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
        }
    }
}
