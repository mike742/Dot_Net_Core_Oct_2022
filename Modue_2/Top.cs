using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modue_2
{
    public class Top
    {
        public Menu Menu { get; set; }

        public void Print()
        {
            Console.WriteLine(Menu.Header);
            foreach (var item in Menu.Items)
            {
                if (item != null)
                {
                    Console.Write("\t");
                    if (item.Id != null)
                    {
                        Console.Write("id: " + item.Id);
                    }
                    if (item.Label != null)
                    {
                        Console.Write($"; label = {item.Label}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\t null");
                }
            }
        }
    }
}
