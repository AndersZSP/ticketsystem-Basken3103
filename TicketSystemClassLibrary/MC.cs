using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    public class MC: Baseclass
    {
        // Properties

       


        /*
         * Metoder
         */


        /// <summary>
        /// This is a method that returns the fixed price at 125
        /// </summary>
        /// <returns>125</returns>
        public override Double Price()
        {
            return (125);
        }


        /// <summary>
        /// This is a method that returns the string MC
        /// </summary>
        /// <returns>MC</returns>
        public override string Vehicle()
        {
            return ("MC");
        }
    }
}
