using System;

namespace Planes
{
    public class ConsoleIO
    {
        public ConsoleIO()
        {
            _planeInitializer = new PlaneInitializer();
            _planeList = new PlaneList();
        }

        private PlaneInitializer _planeInitializer;
        private PlaneList _planeList;

        private void AddPlane()
        {
            Console.WriteLine("enter data in next way: name,number,places,distance");
            var input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    _planeList.Planes.Add(_planeInitializer.GetNewPlane(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                input = Console.ReadLine();
            }
        }
        private void ShowMaxPlaces()
        {
            foreach (var plane in _planeList.GetMaxPlacesPlanes())
            {
                Console.WriteLine("\n" + plane.Name + " " + plane.PlacesAmount);
            }
            
        }
        private void ShowDistance()
        {
            Console.WriteLine("\n" +
                _planeList.GetMinDistance() + " " + 
                _planeList.GetMaxDistance() + " " + 
                _planeList.GetAverageDistance());
        }
        private void ShowAlphList()
        {
            foreach (var plane in _planeList.GetAlphabetizedPlanes())
            {
                Console.WriteLine(plane.Name + " " + plane.Number);
            }
        }
        private void ShowPlanesContainingLetter()
        {
            Console.WriteLine("enter a letter:\n");
            var input = Console.ReadKey().KeyChar;
            while (!char.IsLetter(input))
            {
                Console.WriteLine("enter a letter:\n");
                input = Console.ReadKey().KeyChar;
            }
            foreach (var plane in _planeList.GetPlanesContainingLetter(input))
            {
                Console.WriteLine("\n" + plane.Name + " " + plane.Number);
            }
        }
        private void ShowByType()
        {
            foreach (var plane in _planeList.GroupByType())
            {
                Console.WriteLine(plane.Name + " is cargo = " + plane.IsCargo);
            }
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. alphabetize list\n" +
                              "2. max places\n" +
                              "3. min, max and average diatance\n" +
                              "4. plain names containing letter\n" +
                              "5. group by type\n" +
                              "6. add planes\n");

                var ans = Console.ReadLine();
                var choice = 0;
                if (int.TryParse(ans, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ShowAlphList();
                            break;
                        case 2:
                            ShowMaxPlaces();
                            break;
                        case 3:
                            ShowDistance();
                            break;
                        case 4:
                            ShowPlanesContainingLetter();
                            break;
                        case 5:
                            ShowByType();
                            break;
                        case 6:
                            AddPlane();
                            break;
                        default:
                            Console.WriteLine("wrong selection");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("type numeric value only");
                }
            }
        }
    }
}
