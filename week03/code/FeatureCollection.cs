public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }

    public class Feature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }

    public class Properties
    {
        // Define properties based on the actual properties in your JSON data
        public string Id { get; set; }
        public string Place { get; set; }
        public double Magnitude { get; set; }
        public long Time { get; set; }
        // Add more properties as needed
    }
    }