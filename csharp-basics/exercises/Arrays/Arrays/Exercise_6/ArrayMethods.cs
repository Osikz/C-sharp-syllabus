using System;

namespace Exercise_6
{
    public class ArrayMethods
    {
        public static void RandomArrayNumbers(Random rnd, int[] arrayOne, int[] arrayTwo)
        {
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayOne[i] = rnd.Next(1, 101);
                arrayTwo[i] = arrayOne[i];
            }
        }

        public static void ChangeLastNumber(int[] arrayTwo)
        {
            arrayTwo[^1] = -7;
        }
    }
}
