using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class File1
    {
        static void Main() //정적메서드
        {
            string from = "ConsoleApp0928.exe.config"; //4. 상대 경로
            string to = "myConfig.txt";
            File.Copy(from, to, true); //1. true를 안 쓰면 to 파일이 이미 있는 경우, 오류가 발생할 수 있다.

            if (File.Exists(from)) //3. from의 파일 위치 확인. 있다는 전제 하에 실행.
            {
                string to2222 = "C:/Temp2/myFolder/myConfig_3333.txt";
                //if (! Directory.Exists("C:/Temp2/myFolder")) //5. 만약 디렉토리가 없으면
                //{
                //    Directory.CreateDirectory("C:/Temp2/myFolder"); //6. 괄호안에 디렉토리를 만들어준다 (폴더 2개 이상도 가능)
                //}
                //File.Move(to, to2222); //2. myConfig가 myConfig_3333으로 바뀌었다. 원문은 남아있지 않음

                if (Directory.Exists("C:/Temp2/myFolder")) //5. 만약 디렉토리가 비어있지 않으면
                {
                    Directory.Delete("C:/Temp2/myFolder"); //6. 괄호안에 디렉토리를 삭제한다.
                }

                foreach (string item in Directory.GetFiles("/"))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
