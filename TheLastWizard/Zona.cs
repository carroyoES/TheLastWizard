using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard {
    public class Zona {
        public String descripcion;
        public List<ElementoEntorno> listaElementosEntorno;

        public Zona(String descripcion, ElementoEntorno[] elementosEntorno) {
            this.descripcion = descripcion;
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
