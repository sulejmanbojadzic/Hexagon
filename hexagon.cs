using System;

namespace OOP
{
    class hexagon
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter side length : ");
            int sidelen=Convert.ToInt32(Console.ReadLine());
            string spaces=multistr(" ",sidelen-1);
            int spacenum = sidelen-1;
            string stars=multistr("*",sidelen);
            string firstrow = spaces+stars;

            System.Console.WriteLine(firstrow);

            
            int innerspace=sidelen-2;

            for(int i = 0;i<sidelen-2;i++)
            {
                spacenum-=1;
                innerspace+=2;
                System.Console.WriteLine(multistr(" ",spacenum)+"*"+multistr(" ",innerspace)+"*");
            }
            System.Console.WriteLine("*"+multistr(" ",innerspace+2)+"*");
            spacenum-=1;
            innerspace+=2;
            for(int j =0;j<sidelen-2;j++)
            {
                spacenum+=1;
                innerspace-=2;
                System.Console.WriteLine(multistr(" ",spacenum)+"*"+multistr(" ",innerspace)+"*");
            }
            
            

            System.Console.WriteLine(firstrow);
        Console.ReadKey();
        }
        static string multistr(string str ,int num)
        {
            string str1=str;
            for (int i = 0; i < num-1; i++) 
            {
                str1=str1+str;
            }
            return str1;
        }
    }
}
