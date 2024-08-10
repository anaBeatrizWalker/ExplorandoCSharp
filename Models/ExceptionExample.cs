using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
    public class ExceptionExample
    {
        public void Method1()
        {
            try
            {
                Method2();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exceção sendo tratada: " + ex.Message);
            }
        }

        public void Method2()
        {
            Method3();
        }

        public void Method3()
        {
            Method4();
        }

        public void Method4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}