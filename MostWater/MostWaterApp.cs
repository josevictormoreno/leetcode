
public class MostWaterApp{
    static void Main(){
        int[] vetor = {1,8,6,2,5,4,8,3,7};
        Console.WriteLine(MaxArea(vetor));
    }

    public static int MaxArea(int[] height)
    {
        var max = 0;
        var i = 0;
        var j = height.Length - 1;

        while (i < j)
        {
            if (height[i] < height[j])
            {
                max = Math.Max(max, height[i]*(j - i));
                i++;
            }
            else
            {
                max = Math.Max(max, height[j]*(j - i));
                j--;
            }
        }

        return max;
    }
}