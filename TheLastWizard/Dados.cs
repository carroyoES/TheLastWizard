using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastWizard {
    public class Dados {
        public static int dosDeSeis() {
            Random random = new Random();
            return random.Next(0, 7) + random.Next(0, 7);
        }

        public static int unoDeSeis() {
            Random random = new Random();
            return random.Next(0, 7);
        }
    }
}
