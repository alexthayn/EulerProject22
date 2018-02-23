//Created by Alex Thayn 2/22/2018
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*******************************************************************************************************
 The answer I got was 871198282
 ******************************************************************************************************/


namespace EulerProjectQuestion22
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\p022_names.txt";
            
            var lines = File.ReadAllText(fileName);

            var Names = lines.Split(',').ToList();
            
            Console.WriteLine(Names[0]);
            
            for(int i = 0; i < Names.Count(); i++)
            {
                Names[i] = Names[i].Trim('\"');
            }

            Names.Sort();
            List<int> nameValues = new List<int>();


            for (int i = 0; i < Names.Count(); i++)
            {
                System.Console.WriteLine(Names[i]);
                int charValue = 0;
                String aName = Names[i];
                for(int j = 0; j< aName.Length; j++)
                {
                    char a = aName[j];
                    charValue += (char.ToUpper(a)-64);
                }
                nameValues.Add(charValue * (i+1));
            }

            int score = 0;
            for(int i = 0; i < nameValues.Count(); i++)
            {
                score += nameValues[i];
            }

            Console.Out.WriteLine(score);






            Console.In.Read();


        }
    }
}


/******************
 * Ignore all this
 * ***************/

//var fileName = @"C:\Users\alex.thayn1\Documents\Alex\p022_names.txt";

//var lines = File.ReadAllLines(fileName).Select(a => a.Split(','));
//Console.Out.Write(lines.ToString());
//Console.ReadKey();

//var trimmedNames = Names.Select(x => x == null ? null : x.Trim('\"')).ToList();
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
//Console.Out.Write(trimmedNames[640]);

//var fileName = @"~.\EulerProjectQuestion22\p022_names.txt";
//var fileName = @"C:\Users\Alex Thayn\Documents\GitHub\ProjectEulerNumber22\EulerProject22\EulerProjectQuestion22\p022_names.txt";
