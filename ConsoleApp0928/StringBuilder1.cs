using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class StringBuilder1
    {
        static void Main()
        {
            DateTime dtStart = DateTime.Now;

            //         string txt = "Hello World";
            //         for (int i = 0; i<30000; i++)
            //{
            //             txt += i;
            //}

            StringBuilder sb = new StringBuilder(); //속도 차이
            sb.Append("Hello World");
            //for (int i = 0; i < 300000; i++)
            //{
            //    sb.Append(i);
            //}

            DateTime dtEnd = DateTime.Now;
            double interval = (dtEnd - dtStart).TotalSeconds;
            Console.WriteLine(interval);

            //-----------------------------------------------------------------------------

            sb.Clear(); //초기화
            sb.Remove(0, sb.Length); //0부터 sb의 길이만큼 삭제

            string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };

            sb.Clear();
            foreach (string item in days)
            {
                sb.AppendFormat("{0}", item);//뒤에다가 붙여나가는 것
                sb.AppendLine(item);
            }
            Console.WriteLine(sb.Remove(sb.Length-1, 1));

            int i = 10;
            Console.WriteLine(i);
            Console.WriteLine(i.ToString());

        }
    }
}
