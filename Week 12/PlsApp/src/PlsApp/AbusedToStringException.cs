using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlsApp
{
    public class AbusedToStringException : Exception
    {
        public override string ToString() {
            String message = "This method has been abused due to the demands of the Question. Please contact social services ";
            throw new AbusedToStringException();
        }
    }
}
