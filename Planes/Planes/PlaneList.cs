using System.Collections.Generic;
using System.Linq;

namespace Planes
{
    public class PlaneList
    {
        public PlaneList()
        {
            Planes = new List<Plane>();
        }
        public IList<Plane> Planes { get; set; }

        public int GetMinDistance()
        {
            return Planes.Min(x => x.Distance);
        }
        public int GetMaxDistance()
        {
            return Planes.Max(x => x.Distance);
        }
        public double GetAverageDistance()
        {
            return Planes.Average(x => x.Distance);
        }

        public IEnumerable<Plane> GetAlphabetizedPlanes()
        {
            return Planes.OrderBy(x => x.Name);
        }
        public IEnumerable<Plane> GetMaxPlacesPlanes()
        {
            var maxAmount = Planes.Max(x => x.PlacesAmount);
            return Planes.Where(x => x.PlacesAmount == maxAmount);
        }
        public IEnumerable<Plane> GetPlanesContainingLetter(char letter)
        {
            return Planes.Where(x => x.Name.Contains(letter));
        }
    }
}
