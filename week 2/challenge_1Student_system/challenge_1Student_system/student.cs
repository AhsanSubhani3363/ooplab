using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace challenge_1Student_system
{
    internal class student
    {
        public string name;
        public int matric;
        public int inter;
        public int ecat;
        public int aggregate;
        public student(string Name, int matric_m, int interMarks, int Ecat)
        {
            name = Name;
            matric = matric_m;
            inter = interMarks;
            ecat = Ecat;
            aggregate = 0;
        }
        public void CalculateAggregate()
        {
            aggregate = (int)((matric * 0.25) + (inter * 0.45) + (ecat * 0.30));
            Console.WriteLine(aggregate);

        }


        
    }

}

