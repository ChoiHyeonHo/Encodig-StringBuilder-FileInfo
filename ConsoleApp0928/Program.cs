using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
            //day 배열의 내용을 콘솔로 출력

            #region 일반적인 문자열 연결 방법
            string str = string.Empty;
            StringBuilder sb = new StringBuilder();

            foreach (string item in days)
            {
                sb.Append(item + ','); //str += item + ", ";
            }
            //str=str.Substring(0, str.Length-2);
            Console.WriteLine(sb.ToString().TrimEnd(' ', ',')); //뒤의 ',' 제거, 파라미터 없으면 공백제거
            #endregion

            #region Join 사용법
            string result = string.Join(",", days);
            Console.WriteLine(result);
            #endregion

            #region Split사용
            string fruits = "딸기, 배, 사과, 포도";
            //좋아하는 과일의 내용을 배열에 저장
            string[] arr = fruits.Split(','); //구분자를 기준으로 분할
            Console.WriteLine(arr.Length);
            #endregion


            //더하고자 하는 숫자들을 콘솔로 입력받아서
            //합을 구하여 콘솔로 출력
            //예를들어서 10 50 60 44 55 24 77 => 320

            //Console.Write("더하고자 하는 숫자들을 입력하세요");
            //string input = Console.ReadLine();

            //char[] delimiters = { ',', ' ', '/' };
            //string[] nums = input.Split(delimiters);
            //int sum = 0;
            //foreach (string num in nums)
            //{
            //    sum += int.Parse(num);
            //}
            //Console.WriteLine(sum);

            fruits = "이것이 JAVA다";
            Console.WriteLine(fruits.Contains("JAVA")); //True, False

            Console.WriteLine(fruits.IndexOf("JAVA", StringComparison.OrdinalIgnoreCase)); // 4번째에 있다.

            Console.WriteLine(fruits.ToLower().IndexOf("JAVA".ToLower()));

            for (int i = 1; i < 10 ; i++)
            {
                Console.WriteLine($"5 * {i} = {5*i, 2}");
            }

            Console.WriteLine($"{123456789:C}");

            Console.WriteLine("{0, -20:D} {1, 10:N}", DateTime.Now, 1234567); //0에 DateTime.Now를 넣고 20칸 뜀. 1에 1234567을 넣고

        }
    }
}
