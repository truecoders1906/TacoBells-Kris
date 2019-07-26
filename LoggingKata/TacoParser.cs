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
           // logger.LogInfo("Begin parsing");

            if (line == null)
            { 
                return null; 
            }

            var cells = line.Split(',');

            if (cells.Length < 3)
            {
                logger.LogError("Error");
                return null;
            }

            double latitude = double.Parse(cells[0]);
            double longitude = double.Parse(cells[1]);
            string name = cells[2];

            TacoBell tacoBell = new TacoBell();
            tacoBell.Location = new Point() { Latitude = latitude, Longitude = longitude };
            tacoBell.Name = name;

            return tacoBell;
        }
    }
}