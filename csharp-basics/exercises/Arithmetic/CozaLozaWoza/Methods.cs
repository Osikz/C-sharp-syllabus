using System;

namespace CozaLozaWoza
{
    public class Methods
    {
        public static string CheckForCozaWozaLoza(int index)
        {
            if (index % 11 == 1)
            {
                Console.WriteLine();
            }

            if (index % 3 == 0 && index % 5 == 0)
            {
                return "CozaLoza";
            }
            else if (index % 7 == 0)
            {
                return "Woza";
            }
            else if (index % 5 == 0)
            {
                return "Loza";
            }
            else if (index % 3 == 0)
            {
                return "Coza";
            }
            else
            {
                return $"{index}";
            }
        }
    }
}
