using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard.Enemigos {
    public class Enemigo : ElementoEntorno {
        public int reflejos;
        public bool esquivar(int dificultad) {
            if (Dados.dosDeSeis(this.reflejos) >= dificultad) {
                return true;
            }
            return false;
        }
    }
}
