using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard {
    public class ElementoEntorno {
        public String nombre;
        public Button boton;
        public Juego juego;

        public ElementoEntorno(Juego juego) {
            this.juego = juego;
        }
    }
}
