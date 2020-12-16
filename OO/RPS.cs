using System;
using System.Collections.Generic;
using System.Text;

namespace OO
{
    public enum Hand{ 
        rock = 0,
        paper = 1,
        scissors = 2
    }
    class RPS
    {
        private Random _random;

        public Hand Me { get; set; }
        public Hand Computer { get; set; }
        public int ScoreMe { get; set; }
        public int ScoreComputer { get; set; }

        public RPS()
        {
            _random = new Random();
        }

        public string Turn()
        {
            Computer = (Hand)_random.Next(0, 3);

            string result = "";
            if ((Me == Hand.rock && Computer == Hand.scissors)
                || (Me == Hand.paper && Computer == Hand.rock)
                || (Me == Hand.scissors && Computer == Hand.paper))
            {
                ScoreMe++;
                result = $"Computer: {Computer} --> I win ;)!";
            }
            else if ((Computer == Hand.rock && Me == Hand.scissors)
                || (Computer == Hand.paper && Me == Hand.rock)
                || (Computer == Hand.scissors && Me == Hand.paper))
            {
                ScoreComputer++;
                result = $"Computer: {Computer} --> computer wins :(!";
            }
            else
            {
                result = $"Computer: {Computer} --> nobody wins!";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ScoreMe} - {ScoreComputer}";
        }
    }
}
