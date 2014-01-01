using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCore.SystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RubiksCube cube = new RubiksCube(null);

            Console.WriteLine(cube);


            cube.TurnBack();
            Console.WriteLine(cube);
            cube.TurnDown();
            Console.WriteLine(cube);
            cube.TurnFront();
            Console.WriteLine(cube);
            cube.TurnLeft();
            Console.WriteLine(cube);
            cube.TurnBack();
            Console.WriteLine(cube);
            Console.ReadLine();
            
        }
    }
}
