using System;

namespace 二叉树计算
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int ceng = 0;
            double qian = 0;
            for (int i = 1; qian <= 10000; i++)
            {
                qian += ((Math.Pow(2, i)) * 10000) * (Math.Pow(0.15, i));
                ceng = i;
            }
            Console.WriteLine("发展层数："+ceng);
        }
    }
}
