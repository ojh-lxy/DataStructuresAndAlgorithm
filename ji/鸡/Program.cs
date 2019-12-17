using System;

namespace 鸡
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum=0;
            int x=0 , y=0 , z=0 ;int i = 1;int j = 1;int f = 3;
        
        cc: for (; i + j + (f*3) != 100 && sum != 100; i++)
            {
                sum += 5;
                x = i; y = j; z = f;

                for (; i + j + (f*3) != 100 && sum != 100; j++)
                {
                    sum += 3;
                    x = i; y = j; z = f;

                    for (; i + j + (f*3) != 100 && sum != 100; f++)
                    {
                        sum += 1;
                        
                        if (i + j + (f*3) != 100 && sum != 100)
                        {
                             f++;x = i; y = j; z = f;goto cc;
                        }
                        
                    }
                }
            }
            Console.WriteLine("{0},{1},{2}",x, y, z);
            Console.ReadLine();
        }
    }
}
