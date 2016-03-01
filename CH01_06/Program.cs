using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Image img = new Image(new char[,] { { 'A', 'A', 'A', 'A' }, { 'B', 'B', 'B', 'B' }, { 'C', 'C', 'C', 'C' }, { 'D', 'D', 'D', 'D'} });

            //Image.Rotate90Degrees(img);

            Image.Rotate90DegInPlace(img);
        }       

    }
}
