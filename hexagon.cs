using System;

namespace OOP
/*a=int(input("Enter the side lenght : "))
space=" "*(a-1)
spacenum=len(space)
innerspace=a-2
stars="*"*a
print(space+stars)
for i in range(a-1):
    spacenum-=1
    innerspace+=2
    print(spacenum*" "+"*"+innerspace*" "+ "*")
for i in range(a-2):
    spacenum+=1
    innerspace-=2
    print(spacenum*" "+"*"+innerspace*" "+ "*")
print(space+stars)
*/
{
    class Program
    {
        static void Main(string[] args)
        {
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
