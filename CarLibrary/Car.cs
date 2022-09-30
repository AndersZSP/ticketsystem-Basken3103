namespace CarLibrary
{
    public class Car
    {


        // Properties

        public string Licenseplate { get; set;}
        
        public string DateTimeDate { get; set;}


        /*
         * Metoder
         */


        /// <summary>
        /// This is a method that returns the fixed price at 240
        /// </summary>
        /// <returns>240</returns>
        public static Double Price()
        {
            return (240);
        }

        /// <summary>
        /// This is a method thar returns the String Car
        /// </summary>
        /// <returns>Car</returns>
        public static string VehicleType()
        {
            return ("Car");
        }







    }
}