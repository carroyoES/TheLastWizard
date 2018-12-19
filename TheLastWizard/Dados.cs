using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard {
    class Dados {
        public static int dosDeSeis(int extra){
            Random random = new Random();
            return random.Next(0, 7) + random.Next(0, 7) + extra;
        }
    }
}
