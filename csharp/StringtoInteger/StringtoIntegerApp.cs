public class StringtoIntegerApp
{
    static void Main()
    {
        Console.WriteLine(StringtoInteger("-91283472332"));
    }
    
    public static int StringtoInteger(string numero)
    {
        var i = numero.Length - 1;
        var j = 1;
        var num = 0;
        bool negativo = false;
        bool letra = false;
        bool espaco = false;
        var c = 0;
        while (i >= 0)
        {
            c = numero[i];

            if (espaco && (c > 47 && c < 58))
            {
                num = 0;
                j = 1;
                espaco = false;
            }
            switch (c)
            {
                case 45:
                    negativo = !negativo;
                    break;
                case 48:
                    num += 0 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 49:
                    num += 1 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 50:
                    num += 2 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 51:
                    num += 3 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 52:
                    num += 4 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 53:
                    num += 5 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 54:
                    num += 6 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 55:
                    num += 7 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 56:
                    num += 8 * j;
                    letra = false;
                    j *= 10;
                    break;
                case 57:
                    num += 9 * j;
                    letra = false;
                    j *= 10;
                    break;
                case ' ':
                    espaco = true;
                    break;
                default:
                    letra = true;
                    break;
            }

            i--;
        }
        if (letra)
            return 0;

        if (negativo)
            num *= -1;

        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);
        if (Int32.MinValue > num)
            return Int32.MinValue;
        if (Int32.MaxValue < num)
            return Int32.MaxValue;

        return num;
    }
}