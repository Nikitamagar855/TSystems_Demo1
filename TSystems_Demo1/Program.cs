using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Demo1
{
    public  class Department
    {
       
        private int id;
        private string name,location;

        public void AssignData()
        {
            id = 1;
            name = "Swami";
            location = "Nashik";

        }
        public string GetData()
        {
            return "Dept id \n" + id +"\n"+"Name \n"+name+"\n"+"Location \n"+"\n"+location;
            

        }
    }
}
