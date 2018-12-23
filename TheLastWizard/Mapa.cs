using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLastWizard.Enemigos;
using TheLastWizard.Objetos;
using TheLastWizard.Objetos.Muebles;
using TheLastWizard.Objetos.Varios;

namespace TheLastWizard {
    public class Mapa {
        public Juego juego;
        public Zona[,] matrizMapa;
        public Zona zonaActual;

        public Mapa(Juego juego) {
            this.juego = juego;
            matrizMapa = new Zona[,] {
                { new Zona("Estás en la entrada\n", "", false, null, false, true, false, false), new Zona("Estás en un pasillo.\n", "Un goblin te sale al encuentro.\n", true, new ElementoEntorno[]{new Goblin(juego, new Item[] { new Llave(juego, "LLAVE COCINA") }), new Puerta(juego, true, true, "LLAVE COCINA", "SUR") }, false, false, false, true) },
                { new Zona("Estás en un viejo dormitorio\n", "", false, new ElementoEntorno[]{new Cofre(juego)}, false, true, false, false), new Zona("Estás en lo que parece ser la cocina\n", "", false, null, true, false, false, true)},
            };
        }

        public void actualizarZonaActual(Zona zonaActual) {
            this.zonaActual = zonaActual;
        }
    }
}
