using System;
using System.Linq;


namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            GetVowelCount("good job")

        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            string Glas = "aeiou";
            for(int i = 0;i<str.Length;i++)
            {
                for(int j = 0;j< Glas.Length;j++)
                {
                    if(str[i]==Glas[j])
                    {
                        vowelCount++;
                    }
                }
            }
        

            return vowelCount;
        }

        


    }
    
    
}