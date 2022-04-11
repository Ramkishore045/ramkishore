using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Day26task
{
    class Program
    {
        public static void Main()
        {
            IList<Doctor> DocData = new List<Doctor>()
            {
                new Doctor(){DocId=1 , DoctorName="Abdul the amazing ",Age =25, SpecID = 2},
                new Doctor(){DocId= 2, DoctorName="Giri the great",Age =27, SpecID = 1},
                new Doctor(){DocId= 3, DoctorName="Anandh thangam ",Age =23, SpecID = 3},
                new Doctor(){DocId= 4, DoctorName="Haris malhotra ",Age =22, SpecID = 3},
                new Doctor(){DocId= 5, DoctorName="Sid thalaivan",Age =26, SpecID = 5},
                new Doctor(){DocId= 6, DoctorName=" Delhiyin Dhilli ",Age =24, SpecID = 2},
                new Doctor(){DocId= 7, DoctorName="Vengeance Vishal",Age =35, SpecID = 4},
                new Doctor(){DocId= 8, DoctorName="Ricky John ",Age =21, SpecID = 4}
            };
            IList<Specialisation> SpecData = new List<Specialisation>()
            {
                new Specialisation() {SpecID= 1, SpecialisatinName="General Surgeon"},
                new Specialisation() {SpecID= 2, SpecialisatinName="Nuero Surgeon"},
                new Specialisation() {SpecID= 3, SpecialisatinName="Dermatologist"},
                new Specialisation() {SpecID= 4, SpecialisatinName="Heart surgeon"},
                new Specialisation() {SpecID= 5, SpecialisatinName="Gynaecologist"}
            };
            var JoinData = DocData.Join(
              SpecData,
              stu => stu.SpecID,
              brd => brd.SpecID,
              (stu, brd) => new
              {
                  DocName = stu.DoctorName,
                  specName = brd.SpecialisatinName
              }
                  );
            foreach (var item in JoinData)
            {
                Console.WriteLine("Dr." + item.DocName + " belongs to the  " + item.specName + " specialisation.");
            }




        }
    }
    public class Specialisation
    {
        public int SpecID { get; set; }
        public string SpecialisatinName { get; set; }

    }
    class Doctor
    {
        public int DocId { get; set; }
        public string DoctorName { get; set; }
        public int Age { get; set; }
        public int SpecID { get; set; }
    }
}