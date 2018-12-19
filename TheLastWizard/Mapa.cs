using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLastWizard.Enemigos;

namespace TheLastWizard {
    public class Mapa {
        public Zona[,] matrizMapa;

        public Mapa() {
            matrizMapa = new Zona[,] {
                { new Zona("Estás en la entrada", null), new Zona("Estás en un pasillo. Un goblin te sale al encuentro.", new ElementoEntorno[]{new Goblin() }) },
                { new Zona("Estás en un viejo dormitorio", null), new Zona("Estás en lo que parece ser la cocina", null)},
            };
        }
    }
}
