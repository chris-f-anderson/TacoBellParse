namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {                      
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','

            if (line == null)
            {
                return null;
            }

            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("Error");
                return null; 
            }

            double lattitude, longitude;
            double.TryParse(cells[0], out lattitude);
            double.TryParse(cells[1], out longitude);
            string name = cells[2];
            // Do not fail if one record parsing fails, return null
            TacoBell TB = new TacoBell();
            TB.Name = name;
            TB.Location = new Point() { Latitude = lattitude, Longitude = longitude };
            
            return TB;         
        }
    }
}