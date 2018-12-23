using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastWizard.Objetos {
    public class Item : ElementoEntorno {
        public Item(Juego juego) : base(juego) {
            inicializarBoton();
        }

        public void inicializarBoton() {
            boton = new Button();
            boton.BackColor = Color.Blue;
            boton.Text = nombre;
            boton.ForeColor = Color.White;
            boton.AutoSize = true;
            boton.Click += (s, e) => {
                juego.personaje.agnadirAInventario(this);
                juego.pantalla.flowLayoutPanelSaqueo.Controls.Remove(boton);
            };
        }
    }
}
