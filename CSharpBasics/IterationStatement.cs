using System;

class IterationStatement
{
    static void Main111()

    {
    IterationStatement iterationStatement = new IterationStatement();
    iterationStatement.LearnForLoops();
    }
    void LearnForLoops()
    {
        for (int i=0; i<10; i++)
        {
            Console.WriteLine("I was beautiful");
            

        }
    
        byte[] personAges ={20, 45, 6, 78, 23};
        foreach(byte age in personAges)
        {
            if(age % 2== 0)
            {
                Console.WriteLine(age+"is even");

            }
            else
            {
                Console.WriteLine(age+"is Odd");
            }
        }
    } 
}   
