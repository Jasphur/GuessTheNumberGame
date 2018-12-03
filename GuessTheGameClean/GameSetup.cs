using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheGameClean
{
    class GameSetup : GetUserInput
    {
        public int NumberOfTurns { get; set; }
        public int NumberOfTurnsLeft { get; set; }
        public int LowNumber { get; set; }
        public int HighNumber { get; set; }

        public List<int> NumbersUsed = new List<int>();

        public int SecretNumber { get; set; }
        public int RandomNumber(int SecretNumber)
        {
            Random number = new Random();
            return SecretNumber = number.Next(LowNumber, HighNumber);
        }
    }
}
