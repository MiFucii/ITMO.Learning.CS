namespace Exercise3.Factorial
{
    class FMatch
    {
        public static void FactorialCalculation(int x, out int answer)
        {
            answer = 1;
            checked
            {
                for (int i = 1; i <= x; i++)
                {
                    answer *= i;
                }
            }
        }
    }
}
