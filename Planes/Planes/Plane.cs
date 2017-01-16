namespace Planes
{
    public class Plane
    {
        public Plane(string name, string number, int placesAmount, int diatance)
        {
            Name = name;
            Number = number;
            PlacesAmount = placesAmount;
            Distance = diatance;
            IsCargo = placesAmount == 0;
        }

        public string Name { get; }
        public string Number { get; }
        public int PlacesAmount { get; }
        public int Distance { get; }
        public bool IsCargo { get; }
    }
}
