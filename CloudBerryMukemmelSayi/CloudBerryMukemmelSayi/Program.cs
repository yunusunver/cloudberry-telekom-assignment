using System;

namespace CloudBerryMukemmelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i=1;i<=1000;i++)
            {
                toplam = 0;
                for (int j=1;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        toplam += j;
                    }
                   
                }
                if (i==toplam)
                {
                    Console.WriteLine(i);
                }
               
            }

            Console.ReadKey();
        }
    }
}
