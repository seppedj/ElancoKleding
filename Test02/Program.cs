using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domein;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Domein.Business _business = new Business();

            List<Kraag> gegevens = _business.getTest();

            foreach(var gegeven in gegevens)
            {
                Console.WriteLine(gegeven);
                
            }
            Console.Read();

        }
    }
}
