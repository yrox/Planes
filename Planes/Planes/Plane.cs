namespace Planes
{
    public class Plane
    {
        public Plane(string name, string number, int placesAmount, int diatance, bool isCargo = false)
        {
            Name = name;
            Number = number;
            PlacesAmount = placesAmount;
            Distance = diatance;
            IsCargo = isCargo;
        }

        public string Name { get; }
        public string Number { get; }
        public int PlacesAmount { get; }
        public int Distance { get; }
        public bool IsCargo { get; }
    }
}
