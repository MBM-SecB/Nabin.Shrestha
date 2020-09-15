using System;

class First
{
    static void main()
    {
        First zz = new First();
        zz.First12();
    }
    
    void First12()
    {
        Console.Write("Enter the String of two words:");
        string input = Console.ReadLine();
        string h ="";
        h +=(input[0]);
        string r ="";
        for (int i=0;i<input.Length; i++ )
        {
            if(input[i] == ' ')
            {
                r +=(input[i+1]);

            }
        }

        h +=(r);

        Console.Write("The Concatenated string is:{0}",h);
    }        
        


        

}



