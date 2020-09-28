using AssignmentNektarios.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.Store
{
    public class Shirt
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }


        public Shirt()
        {

        }
        public Shirt(Color color ,Size size,Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
            
        }

        public void Output()
        {
            Console.WriteLine("{0, 12} | {1, 12} | {2, 12}", Color, Size, Fabric);
        }

        public string CalculatePrice(int num)
        {
            if (num == 0)
               return"You have to pay 25E"; 
            else if (num == 1)
                return "You have to pay 23E";
            else if (num == 2)
                return "You have to pay 31E";
            else if (num == 3)
                return "You have to pay 20E";

            else if (num == 4)
                return "You have to pay 17E";

            else if (num == 5)
                return "You have to pay 19E";

            else if (num == 6)
                return "You have to pay 33E";

            else
                return "No value";


        }


    }
}
