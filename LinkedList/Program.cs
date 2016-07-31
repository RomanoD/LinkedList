using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3", 1);

            list.Remove(1);
            list.Clear();
        }
    }
}
