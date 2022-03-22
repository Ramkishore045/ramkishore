using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace day12

{
    [Serializable]
    class Employeedets
    {

        public string name = "Sid the great";
        public int age = 25;
        public string Empid = "ABC$321";
        public string gender = "Male";

    }
    class Program
    {
        public void SeretoFile()
        {
            Employeedets sobj = new Employeedets();
            FileStream fs = new FileStream("Empdets.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, sobj);
            fs.Close();
        }
        public void Dserial()
        {
            FileStream fs = new FileStream("Empdets.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            Employeedets stu = (Employeedets)f.Deserialize(fs);
            Console.WriteLine(stu.name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.gender);
            Console.WriteLine(stu.Empid);



        }

        public static void Main()
        {
            Program lobj = new Program();
            lobj.SeretoFile();
            lobj.Dserial();
            Console.ReadLine();

        }
    }
}