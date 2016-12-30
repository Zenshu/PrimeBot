using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeBot
{
    public class SampleData
    {
        public List<country> Countries;
        public List<persondata> People;

        public SampleData()
        {
            Countries = new List<country>();
            People = new List<persondata>();

            Countries.Add(new Country(1, "United Kingdom"));
            Countries.Add(new Country(2, "United States"));
            Countries.Add(new Country(3, "Republic of Ireland"));
            Countries.Add(new Country(4, "India"));
            {
    }
}
