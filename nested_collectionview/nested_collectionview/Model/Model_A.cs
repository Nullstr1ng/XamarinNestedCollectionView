using System.Collections.Generic;

namespace nested_collectionview.Model
{
    public class offer
    {
        public string title { get; set; }
        public List<location> Locations { get; set; } = new List<location>();
    }

    public class location
    {
        public string City { get; set; }
    }
}