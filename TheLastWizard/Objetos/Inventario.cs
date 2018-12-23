using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLastWizard.Objetos.Varios;

namespace TheLastWizard.Objetos {
    public class Inventario {
        public List<Item> itemsEnPosesion;

        public Inventario(List<Item> itemsEnPosesion) {
            this.itemsEnPosesion = itemsEnPosesion;
        }

        public bool contieneLlaveCorrecta(String descripcionLlaveQueLaAbre) {
            foreach(Item item in itemsEnPosesion) {
                if(item is Llave) {
                    if((item as Llave).descripcion.Equals(descripcionLlaveQueLaAbre)) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
