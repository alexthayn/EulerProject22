using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectQuestion22
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "C:\\Users\\Alex Thayn\\Documents\\GitHub\\ProjectEulerNumber22\\EulerProject22\\EulerProjectQuestion22\\p022_names.txt";
            var lines = File.ReadAllLines(fileName).Select(a => a.Split(','));
            Console.Out.Write(lines.ToString());
            Console.ReadKey();
        }
    }
}
