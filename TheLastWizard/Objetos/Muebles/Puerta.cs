using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Objetos.Muebles {
    public class Puerta : Mueble {
        public bool cerrada;
        public bool cerradaConLlave;
        public String direccionALaQueDaPaso;
        public String descripcionLlaveQueLaAbre;
        // TODO : public Puerta puertaGemela; // Todo lo que le pase a esta puerta tendrá que pasarle a su "sombra" de la zona opuesta(ella misma)

        public Puerta(Juego juego, bool cerrada, bool cerradaConLlave, String descripcionLlaveQueLaAbre, String direccionALaQueDaPaso) : base(juego) {
            this.cerrada = cerrada;
            this.cerradaConLlave = cerradaConLlave;
            this.descripcionLlaveQueLaAbre = descripcionLlaveQueLaAbre;
            this.direccionALaQueDaPaso = direccionALaQueDaPaso;
            this.sePuedeAbrir = true;
            this.nombre = "Puerta";
            boton.Text = nombre;
        }

        public override void abrir() {
            // TODO : mecanismo para regular cerradura
            // La zona que bloqueaba queda despejada
            if (cerradaConLlave) {
                Juego.agnadirTextoPanelCentral("Está cerrada con llave\n");
                juego.personaje.ultimoBotonAccionPulsado = null;
            }
            else {
                cerrada = false;
                juego.personaje.ultimoBotonAccionPulsado = null;
                Juego.agnadirTextoPanelCentral("Abres la puerta\n");
                switch (direccionALaQueDaPaso) {
                    case "NORTE":
                        juego.mapa.zonaActual.caminableNorte = true;
                        break;
                    case "ESTE":
                        juego.mapa.zonaActual.caminableEste = true;
                        break;
                    case "SUR":
                        juego.mapa.zonaActual.caminableSur = true;
                        break;
                    case "OESTE":
                        juego.mapa.zonaActual.caminableOeste = true;
                        break;
                }
            }
        }
    }
}
