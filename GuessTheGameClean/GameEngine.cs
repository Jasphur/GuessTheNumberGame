using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheGameClean
{
    class GameEngine : GameSetupAndUserInput
    {


        public bool SecretNumberCheck(bool NextTurn)
        {
            // Controleren of input getal al eens eerder is gebruikt.
            if (NumbersUsed.Contains(UserInput))
            {
                Console.WriteLine($"\nJe hebt het getal {UserInput} al geprobeerd. Probeer een ander getal \n \n");
                NextTurn = true;
            }

            // Controleren of input getal binnen opgegeven bereik ligt.
            else if (UserInput < LowNumber || UserInput > HighNumber )
            {
                Console.WriteLine("\nDat is geen geldige invoer. \n \n");
                NextTurn = true;
            }

            // Controleren of input getal gelijk is aan het geheime getal.
            else if (UserInput == SecretNumber)
            {
                Console.WriteLine($"\nGefeliciteerd, dat was het juiste getal! Je hebt het in {NumberOfTurns - NumberOfTurnsLeft} keer geraden! \n \n");
                NextTurn = false;
            }

            // Afhandeling niet raden van geheim getal.
            else if (UserInput != SecretNumber)
            {
                if (NumberOfTurnsLeft == 1)
                {
                    Console.WriteLine($"\nSorry, je hebt het niet geraden. Het geheime nummer was {SecretNumber}. \n \n");
                    NextTurn = false;
                }

                else
                {
                    Console.WriteLine($"\nHelaas, dat was niet het juiste nummer, je kan het nog {NumberOfTurnsLeft - 1} keer proberen.\n \n");
                    NumbersUsed.Add(UserInput);
                    NumberOfTurnsLeft--;
                    NextTurn = true;
                }
            }

            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadLine();
            Console.Clear();

            return NextTurn;
        }
    }
}
