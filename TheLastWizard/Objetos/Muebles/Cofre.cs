using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Objetos.Muebles {
    public class Cofre : Mueble {
        public Cofre(Juego juego) : base(juego) {
            this.nombre = "Cofre";
            this.boton.Text = nombre;
            this.sePuedeAbrir = true;
        }
    }
}
