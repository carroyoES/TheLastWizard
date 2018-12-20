using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLastWizard.Enemigos;

namespace TheLastWizard {
    public class Zona {
        public String descripcion;
        public String descripcionEncuentro;
        public bool descripcionEncuentroActivada;
        public List<ElementoEntorno> listaElementosEntorno;
        public bool caminableNorte;
        public bool caminableEste;
        public bool caminableSur;
        public bool caminableOeste;

        public Zona(String descripcion, String descripcionEncuentro, bool descripcionEncuentroActivada, ElementoEntorno[] elementosEntorno, bool caminableNorte, bool caminableEste,
            bool caminableSur, bool caminableOeste) {
            this.descripcion = descripcion;
            this.descripcionEncuentroActivada = descripcionEncuentroActivada;
            this.descripcionEncuentro = descripcionEncuentro;
            this.caminableNorte = caminableNorte;
            this.caminableEste = caminableEste;
            this.caminableSur = caminableSur;
            this.caminableOeste = caminableOeste;
            crearListaElementosEntorno(elementosEntorno);
        }

        public void crearListaElementosEntorno(ElementoEntorno[] elementosEntorno) {
            listaElementosEntorno = new List<ElementoEntorno>();
            try {
                foreach (ElementoEntorno elementoEntorno in elementosEntorno) {
                    listaElementosEntorno.Add(elementoEntorno);
                }
            }
            catch (Exception e) { };
        }

        public bool tieneEnemigo() {
            foreach(ElementoEntorno elementoEntorno in listaElementosEntorno) {
                if(elementoEntorno is Enemigo) {
                    return true;
                }
            }
            return false;
        }

        public Enemigo obtenerEnemigo() {
            foreach (ElementoEntorno elementoEntorno in listaElementosEntorno) {
                if (elementoEntorno is Enemigo) {
                    return elementoEntorno as Enemigo;
                }
            }
            return null;
        }
    }
}
