using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Objetos.Varios {
    public class Llave : Item {
        public String descripcion;
        public Llave(Juego juego, String descripcion) : base(juego){
            nombre = "Llave";
            this.descripcion = descripcion;
            boton.Text = nombre;
        }
    }
}
