using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard {
    class Mapa {
        public Zona[,] matrizMapa;

        public Mapa() {
            matrizMapa = new Zona[,] {
                { new Zona("Estás en la entrada"), new Zona("Estás en un pasillo") },
                { new Zona("Estás en un viejo dormitorio"), new Zona("Estás en lo que parece ser la cocina")},
            };
        }
    }
}
