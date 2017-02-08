using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class AbusedToStringException : Exception {

        public override string ToString() {
            throw new AbusedToStringException();
        }

    }
}
