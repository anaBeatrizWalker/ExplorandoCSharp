using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
    public class ReadFile
    {
        public (bool Success, string[] Lines, int LinesQuantity) ReadAndReturnFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            }
            catch(Exception ex)
            {
               return (false, new string[0], 0);     
            }

        }
    }
}