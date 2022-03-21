using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace ConsoleApp1
{
    class Task2
    {
        public static void Main()

        {
            FileStream fs = new FileStream("E:\\softura training\\DAY10\\DAY11 TASK\\det.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            BinaryWriter bw1 = new BinaryWriter(fs);
            BinaryWriter bw2 = new BinaryWriter(fs);
            BinaryWriter bw3 = new BinaryWriter(fs);
            bw.Write("ASP.NET\n");
            bw1.Write("RAMKISHORE\n");
            bw2.Write("21\n");
            bw3.Write("Male\n");
            bw.Flush();
            bw1.Flush();
            bw2.Flush();
            bw3.Flush();
            fs.Close();
            FileStream fs1 = new FileStream(@"E:\\softura training\\DAY10\\DAY11 TASK\\det.txt", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            BinaryReader br1 = new BinaryReader(fs1);
            BinaryReader br2 = new BinaryReader(fs1);
            BinaryReader br3 = new BinaryReader(fs1);

            string str = br.ReadString();
            string str1 = br1.ReadString();
            string str2 = br2.ReadString();
            string str3 = br3.ReadString();
    
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            fs1.Close();
            Console.Read();
        }


    }
}
