using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Demo1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
            dept.AssignData();
            //  String str=dept.GetData();
            /// Console.WriteLine(str);
            Console.WriteLine(dept.GetData());
            Console.ReadLine();
        }

    }
}
