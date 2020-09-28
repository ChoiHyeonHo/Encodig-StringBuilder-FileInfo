using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class FileInfo1
    {
        static void Main() //Instance 메서드
        {
            string from = "ConsoleApp0928.exe.config"; 
            string to = "myConfig.txt";

            FileInfo fromFile = new FileInfo(from);

            if (fromFile.Exists)
            {
                FileInfo toFile = fromFile.CopyTo(to, true);

                string to2222 = "C:/Temp2/myFolder/myConfig_3333.txt";
                
                fromFile.MoveTo(to); 
            }
        }
    }
}
