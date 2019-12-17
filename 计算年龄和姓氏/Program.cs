using System;
using 计算年龄和姓氏.Properties;

namespace 计算年龄和姓氏
{
    class MainClass
    {
        public static void Main(string[] args)
        {            
            var result = "";
            var totalDays = 0;  
            var now = DateTime.Now;
            ListClass list = new ListClass();
            foreach (var item in list.InitialPersonList())
            {
                totalDays = totalDays + Math.Abs(((TimeSpan)(now - item.Birthday)).Days);
            }

            var avgTotaldays = totalDays / list.InitialPersonList().Count;
            var avgYears = avgTotaldays / 365;
            var avgDays = avgTotaldays - avgYears * 365;

            result = "平均年龄：" + avgYears + "周岁" + "-" + avgDays + "天";
            Console.Write(result);            
        }
    }
}
