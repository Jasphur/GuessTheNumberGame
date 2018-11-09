using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheGameClean
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instellen voorwaarden voor het spel.
            var newGame = new GameEngine
            {
                // Aantal beurten + 1, zodat de 0 geen beurt is.
                NumberOfTurns = 4,
                // Aantal beurten
                NumberOfTurnsLeft = 3,
                // Minimale waarde voor geheim getal.
                LowNumber = 1,
                // Maximale waarde voor geheim getal.
                HighNumber = 10
            };

            // Ophalen gehem getal
            newGame.SecretNumber = newGame.RandomNumber(newGame.SecretNumber);

            // Console Interface voor het spel, starten nieuwe ronde.
            Start:
            Console.WriteLine($"--------------------------------- SECRET NUMBER GAME! RONDE {newGame.NumberOfTurns - newGame.NumberOfTurnsLeft} van {newGame.NumberOfTurns - 1}! ---------------------------------");
            Console.WriteLine($"Kies een getal tussen de {newGame.LowNumber} en de {newGame.HighNumber} en druk op <ENTER>");

            // Onderstaande code gebruiken zodat je kan checken of geheim getal goed wordt opgeslagen.
            //Console.WriteLine($"Tijdelijke weergave geheim getal: {newGame.SecretNumber}");

            // Ophalen input van gebruiker
            newGame.UserInput = newGame.GetUserInputNumber();

            // Bij fout antwoord en recht op nog een keer proberen,
            // teruggaan naar begin, voor het starten van een nieuwe ronde.
            if (newGame.SecretNumberCheck(true))
            {
                goto Start;
            }

            #region Close Prompt
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit..");
            Console.ReadLine(); 
            #endregion

        }
    }
}
