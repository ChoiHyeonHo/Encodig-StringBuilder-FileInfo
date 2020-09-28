using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class String1
    {
        static void Main()
        {
            string txt = "Hello World ";

            //Contains: 문자열 포함 여부 true, false 반환
            Console.WriteLine(txt + "Contains(\"Hello\"): " + txt.Contains("Hello"));
            Console.WriteLine(txt + "Contains(\"Halo\"): " + txt.Contains("Halo"));
            Console.WriteLine();

            //EndWith: 인자로 전달된 문자열로 끝나는지 true, false 반환
            Console.WriteLine(txt + "EndWith(\"World\"): " + txt.EndsWith("World"));
            Console.WriteLine(txt + "EndWith(\"ello\"): " + txt.EndsWith("ello"));
            Console.WriteLine();

            //GetHashCode: 문자열의 해시값을 반환
            Console.WriteLine(txt + "GetHashCode(): " + txt.GetHashCode());
            Console.WriteLine("Hello GetHashCode(): " + "Hello".GetHashCode());
            Console.WriteLine();

            //IndexOf: 문자열 포함하면 위치반환, 없으면 -1
            Console.WriteLine(txt + "IndexOf(\"World\"): " + txt.IndexOf("World"));
            Console.WriteLine(txt + "IndexOf(\"Halo\"): " + txt.IndexOf("Halo"));
            Console.WriteLine();

            //RePlace: 첫번째 인자를 두번째 인자로 치환
            Console.WriteLine(txt + "Replace(\"World\", \"\"): " + txt.Replace("World", ""));
            Console.WriteLine(txt + "Replace('o', 't'): " + txt.Replace('o', 't'));
            Console.WriteLine();

            //Split: 문자 또는 문자열을 구분자 기준으로 나뉜 문자열의 배열을 반환
            Console.Write(txt + "Spilt('o'): ");
            OutputArrayString(txt.Split('o'));
            Console.Write(txt + " Split(' '): ");
            OutputArrayString(txt.Split(' '));
            Console.WriteLine();

            //StartWith: 인자로 전달된 문자열로 시작하는지 true, false 반환
            Console.WriteLine(txt + " StartWith(\"Hello\"): " + txt.StartsWith("Hello"));
            Console.WriteLine(txt + " StartWith(\"ello\"): " + txt.StartsWith("ello"));
            Console.WriteLine();

            //Substring: 시작과 길이에 해당하는 만큼의 문자열을 반환
            Console.WriteLine(txt + "Substring(1): " + txt.Substring(1));
            Console.WriteLine(txt + "Substring(2, 3): " + txt.Substring(2, 3));
            Console.WriteLine();

            //ToUpper, ToLower: 문자열을 대소문자로 변환
            Console.WriteLine(txt + "ToLower(): " + txt.ToLower());
            Console.WriteLine(txt + "ToUpper(): " + txt.ToUpper());
            Console.WriteLine();

            //Trim: 공백 제거
            Console.WriteLine("\" Hello World \" Trim(): " + " Hello World".Trim());
            Console.WriteLine(txt + "Trim('H'): " + txt.Trim('H'));
            Console.WriteLine(txt + "Trim('H', 'd'): " + txt.Trim('H', 'd'));
            Console.WriteLine();

            //Length: 문자열의 길이를 정수로 반환
            Console.WriteLine(txt + " Length: " + txt.Length);
            Console.WriteLine("Hello Length: " + "Hello".Length);
            Console.WriteLine();
        }

        private static void OutputArrayString(string[] arr)
        {
            foreach (string txt in arr)
            {
                Console.WriteLine(txt + ", ");
            }
            Console.WriteLine();
        }
    }
}
