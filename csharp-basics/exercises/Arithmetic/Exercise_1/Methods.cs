namespace Exercise_1
{
    public class Methods
    {
        public static bool CheckNumber(int numOne, int numTwo)
        {
            if (numOne == 15 || numTwo == 15)
            {
                return true;
            }
            else if (numOne + numTwo == 15 || numOne - numTwo == 15 || numTwo - numOne == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
