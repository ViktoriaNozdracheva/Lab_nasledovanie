using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Cource Obj = new Cource(Organization: "Epam Рязань", Level: "Внешние курсы", Name: "Автоматизированное тестирование ПО");
            Obj.InfoPr();

            Console.ReadKey();
        }
    }
}

