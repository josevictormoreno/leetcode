namespace MaximumNumber
{
    public class MaximumNumberApp
    {
        static void Main()
        {
            Console.WriteLine(MaximumNumber(9699));
        }

        public static int MaximumNumber(int num)
        {
            int numero = 0;
            char[] numeroText = num.ToString().ToCharArray();
            int i = 0;

            while (i < numeroText.Length)
            {
                if (numeroText[i].Equals('6'))
                {
                    numeroText[i] = '9';
                    return Int32.Parse(numeroText);
                }
                i++;
            }

            return numero;
        }
    }
}