using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLastWizard.Enemigos;

namespace TheLastWizard.Magia {
    public class BolaDeFuego : Hechizo {

        public BolaDeFuego() {
            this.descripcion = "Lanzas una bola de fuego que consume al Goblin";
            // TODO : Y si no hay enemigo se describe de forma distinta etc
            this.necesitaObjetivo = true;
            this.dificultadEsquivar = 8;
        }

        public override void lanzar(ElementoEntorno elementoEntorno) {
            Juego.agnadirTextoPanelCentral("Lanzas una bola de fuego sobre " + elementoEntorno.nombre);
            // Se comprueba si se ha lanzado contra un enemigo:
            if (elementoEntorno is Enemigo) {
                Enemigo enemigo = elementoEntorno as Enemigo;
                // El enemigo intenta esquivar:
                if (enemigo.esquivar(dificultadEsquivar)) {
                    Juego.agnadirTextoPanelCentral(elementoEntorno.nombre + " ha sido alcanzado por la bola de fuego!");
                }
                else {
                    Juego.agnadirTextoPanelCentral(elementoEntorno.nombre + " ha esquivado la bola de fuego!");
                }
            }
        }
    }
}
