using System;

namespace Planes
{
    public class PlaneInitializer
    {
        private string[] _input;
        private int _distance;
        private int _placesAmount;
        
        private bool IsNumberOfWordsCorrect()
        {
            return _input.Length == 4;
        }

        public Plane GetNewPlane(string input)
        {
            _input = input.Split(new[] {","}, StringSplitOptions.None);

            if (!IsNumberOfWordsCorrect())
                throw new Exception("\nplease enter data in next way:\nname,number,places,distance");
            if (!int.TryParse(_input[2], out _placesAmount) || _placesAmount < 0)
                throw new Exception("\nplaces amount should be a postive integer");
            if (!int.TryParse(_input[3], out _distance) || _distance < 0)
                throw new Exception("\ndistance should be a positive integer");
            return new Plane(_input[0], _input[1], _placesAmount, _distance);
        }
    }
}
