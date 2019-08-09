using nested_collectionview.Model;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace nested_collectionview.ViewModel
{
    public class ViewModel_A
    {
        public ObservableCollection<offer> Offers { get; set; } = new ObservableCollection<offer>();

        public void Refresh()
        {

            for (int o = 0; o < 10; o++)
            {
                Offers.Add(new offer()
                {
                    title = "Title " + o,
                    Locations = new List<location>()
                    {
                        new location() { City = "City 1" },
                        new location() { City = "City 2" },
                        new location() { City = "City 3" },
                        new location() { City = "City 4" },
                    }
                });
            }
        }
    }
}