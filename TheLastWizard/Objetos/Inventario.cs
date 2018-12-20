using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Objetos {
    public class Inventario {
        public List<Item> itemsEnPosesion;

        public Inventario(List<Item> itemsEnPosesion) {
            this.itemsEnPosesion = itemsEnPosesion;
        }
    }
}
