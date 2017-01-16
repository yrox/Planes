using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Planes
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new PlaneList();
            list.Planes.Add(new Plane("111", "sss", 12, 0));
            list.Planes.Add(new Plane("22", "sss", 24, 100));
            list.Planes.Add(new Plane("21", "sss", 0, 50));
            list.GetAlphabetizedPlanes();
            list.GetAverageDistance();
            list.GetMaxDistance();
            list.GetMaxPlacesPlanes();
            list.GetMinDistance();
            list.GetPlanesContainingLetter('1');
        }
    }
}
