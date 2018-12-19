using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Magia {
    public class BolaDeFuego : Hechizo {

        public BolaDeFuego() {
            this.descripcion = "Lanzas una bola de fuego que consume al Goblin";
            // TODO : Y si no hay enemigo se describe de forma distinta etc
            this.necesitaObjetivo = true;
        }

        public override void lanzar(ElementoEntorno elementoEntorno) {
            Juego.agnadirTextoPanelCentral("Lanzas una bola de fuego sobre " + elementoEntorno.nombre);
        }
    }
}
