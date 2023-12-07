public class control
{
    public static string[] countSimbols(string[] n)
    {  
        string[] result = new string[n.Length];
        int index = 0;
        foreach(string x in n)
        {
            if(x.Length <= 3)
            {
                result[index] = x;
                index++;
            }
        }
        Array.Resize(ref result, index);
        return result;
    }
    public static void printSimbols(string[] n)
    {
        for(int i = 0; i < n.Length; i++)
        {
            System.Console.Write(n[i]);
            if(i < n.Length - 1)
            {
            System.Console.Write(" , ");
            }
        }
    }

    public static void Main(string[] args)
    {
        string[] letters = {"Hello", "2", "world", ":-)"};
        printSimbols(countSimbols(letters));
    }
}