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
            puntosVida = 6;
            puntosArmadura = 2;
            vivo = true;
            inicializarBoton();           
        }

        public void inicializarBoton() {
            boton = new Button();
            boton.BackColor = Color.Green;
            boton.Text = nombre;
            boton.ForeColor = Color.White;
            boton.AutoSize = true;
            boton.Click += (s, e) => {
                if (Personaje.hechizoCargado.necesitaObjetivo) {
                    Personaje.hechizoCargado.lanzar(this);
                }
            };
        }

    }
}
