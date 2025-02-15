using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\FASTECH LAPTOP\\Desktop\\oop\\week 1 c#\\oop lab\\test.txt";
            StreamWriter filevariable =new StreamWriter(path,true);
            filevariable.WriteLine("hello");
            filevariable.Flush();
            filevariable.Close();
        }
    }
}
