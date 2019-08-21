using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuildTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Name = "Tyler", Age = 30 };
            string jonStr = JsonConvert.SerializeObject(obj);
            Console.WriteLine(jonStr);
            Console.ReadKey();
        }
    }
}
