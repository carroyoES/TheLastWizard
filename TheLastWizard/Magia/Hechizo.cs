using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Magia {
    public class Hechizo {
        public String descripcion;
        public bool necesitaObjetivo;
        public int dificultadEsquivar;

        public virtual void lanzar(ElementoEntorno elementoEntorno) { }
    }   
}
