using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard {
    public class Zona {
        public String descripcion;
        public List<ElementoEntorno> listaElementosEntorno;
        public bool caminableNorte;
        public bool caminableEste;
        public bool caminableSur;
        public bool caminableOeste;

        public Zona(String descripcion, ElementoEntorno[] elementosEntorno, bool caminableNorte, bool caminableEste,
            bool caminableSur, bool caminableOeste) {
            this.descripcion = descripcion;
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
    }
}
