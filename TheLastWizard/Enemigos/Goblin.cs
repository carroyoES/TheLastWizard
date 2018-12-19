using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard.Enemigos {
    public class Goblin : Enemigo {
        public Goblin() {
            nombre = "Goblin";
            reflejos = 3;
            inicializarBoton();           
        }

        public void inicializarBoton() {
            boton = new Button();
            boton.BackColor = Color.Green;
            boton.Text = nombre;
            boton.ForeColor = Color.White;
            boton.Click += (s, e) => {
                if (Personaje.hechizoCargado.necesitaObjetivo) {
                    Personaje.hechizoCargado.lanzar(this);
                }
            };
        }

    }
}
