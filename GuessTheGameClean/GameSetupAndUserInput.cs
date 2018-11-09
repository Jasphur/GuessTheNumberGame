using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheGameClean
{
    class GameSetupAndUserInput
    {
        public int NumberOfTurns { get; set; }
        public int NumberOfTurnsLeft { get; set; }
        public int LowNumber { get; set; }
        public int HighNumber { get; set; }

        // Lijst waar ingevoerde input getallen in worden bewaard,
        // zodat deze geen tweede keer kan worden gebruikt.
        public List<int> NumbersUsed = new List<int>();

        // Aanmaken geheim getal.
        public int SecretNumber { get; set; }
        public int RandomNumber(int SecretNumber)
        {
            Random number = new Random();
            return SecretNumber = number.Next(LowNumber, HighNumber);
        }

        // Opvragen gebruikers input en controlleren op geldigheid.
        public int UserInput { get; set; }
        public int GetUserInputNumber()
        {
            var UncheckedUserInput = Console.ReadLine();

            // Controlleren of input een integer is.
            int check;
            bool isNumber = int.TryParse(UncheckedUserInput, out check);

            if (isNumber == false)
                UserInput = LowNumber - 1;

            else
                UserInput = Convert.ToInt32(UncheckedUserInput);

            return UserInput;
        }
    }
}
