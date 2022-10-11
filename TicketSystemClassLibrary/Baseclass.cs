namespace TicketSystemClassLibrary
{
    
    /// <summary>
    /// Baseclass indeholder data fra Car og MC class
    /// </summary>
    
    public abstract class Baseclass
    {
        public string Licenseplate { get; set; }

        public string DateTimedate { get; set; }


        /// <summary>
        /// Det her er Price abstract metoden fra klassen Car 
        /// </summary>
        /// <returns>240</returns>
        public abstract double Price();

        /// <summary>
        /// Det her er Vechile abstract metoden fra klassen MC
        /// </summary>
        /// <returns>125</returns>
        public abstract string Vehicle();

        



    }
}
