using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class DOR
    {
        public static void Main()
        {
            Queue q = new Queue();
            q.Enqueue("Ice cream");
            q.Enqueue("Falooda");
            q.Enqueue("Lassi");
            q.Enqueue("Gulab jamuns");
            q.Enqueue("Coconut Truffle");
            q.Enqueue("Rasamalai");
            q.Enqueue("Caramel Custard");
            q.Enqueue("Lichi Mousse");
            FileStream fs = new FileStream("E:\\softura training\\DAY10\\DAY11 TASK\\DOR.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter br = new BinaryWriter(fs);
            foreach (string cal in q)
            {
                br.Write("\n" + cal);
            }
            br.Flush();
            fs.Close();
            FileInfo fs1 = new FileInfo("E:\\softura training\\DAY10\\DAY11 TASK\\DOR.txt");
            Console.WriteLine(fs1.Length);
            Console.WriteLine(fs1.CreationTime);
            Console.ReadLine();
        }
    }
}
