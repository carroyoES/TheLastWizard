using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Objetos.Muebles {
    public class Mueble : ElementoEntorno {
        public bool sePuedeAbrir;

        public Mueble(Juego juego) : base(juego) {
            inicializarBoton();
        }

        private void inicializarBoton() {
            boton = new System.Windows.Forms.Button();
            boton.BackColor = Color.Brown;
            boton.ForeColor = Color.White;
            boton.AutoSize = true;
            boton.Click += (s, e) => {
                // Si lo último que ha hecho el jugador ha sido pulsar lanzar hechizo:
                if (juego.personaje.ultimoBotonAccionPulsado == juego.pantalla.botonLanzarHechizo) {
                    if (juego.personaje.hechizoCargado.necesitaObjetivo) {
                        juego.personaje.hechizoCargado.lanzar(this);
                    }
                }
                // Si lo último que ha hecho el jugador ha sido pulsar abrir:
                if(juego.personaje.ultimoBotonAccionPulsado == juego.pantalla.botonAbrir) {
                    if (this.sePuedeAbrir) {
                        abrir();
                    }
                    else {
                        Juego.agnadirTextoPanelCentral("Este mueble no se puede abrir");
                    }
                }
            };
        }

        public virtual void abrir() { }
    }
}
