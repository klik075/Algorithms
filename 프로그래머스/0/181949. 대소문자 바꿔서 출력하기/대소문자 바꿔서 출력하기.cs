using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        char[] charString = s.ToCharArray();
        for(int i = 0; i < charString.Length;i++)
        {
            if(char.IsUpper(charString[i]))
            {
                charString[i] = char.ToLower(charString[i]);
            }
            else
            {
                charString[i] = char.ToUpper(charString[i]);
            }
        }
        string result = new string(charString);
        Console.WriteLine(result);
    }
}