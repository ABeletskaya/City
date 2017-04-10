using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    struct City
    {
        string Name;
        int population;
    }


    class Program
    {
        static void Main(string[] args) 
        {
            string userEnter = Console.ReadLine();
            string[] stringSeparators = new string[] { "," };
            string[] result;
            result = userEnter.Split(stringSeparators, StringSplitOptions.None);

            City[] city = new City[result.Length];

            string[] stringSeparators2 = new string[] { "=" };
            int i;
            string[] result2;
            int index = 0;
            for(i=0;i<result.Length;i++)
            {
              stringSeparators = new string[] { "=" };
              result2 = result[i].Split(stringSeparators, StringSplitOptions.None);
                foreach (string s in result2)
                {
                    Console.WriteLine(s);
                    
                 }
                               
            }

        }
    }
}
