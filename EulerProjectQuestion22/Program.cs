using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EulerProjectQuestion22
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"C:\Users\alex.thayn1\Documents\Alex\p022_names.txt";
            var lines = File.ReadAllText(fileName);

            var Names = lines.Split(',').ToList();
            //Names[0] = Names[0].Trim('\"');
            var trimmedNames = Names.Select(x => x == null ? null : x.Trim('\"')).ToList();
            //var sumLines = lines.Sum(a => Double.Parse(a.Split(',')[1])) / lines.Count();
            //var sortedLine = lines.OrderBy(a => a.Split(',')[1]).ToList();
            //var file = File.ReadAllText(fileName);
            //var lines2 = file.Split(',');

            /*foreach(var line in lines)
            {
                var data = line.Split(',');
            }
            */

            //IEnumerable<string> trimmed = Names.Select(s => s.Trim('\"'));

        
            //Names.Trim('\"');
            Console.Out.Write(trimmedNames[640]);
            Console.In.Read();

        }
    }
}
