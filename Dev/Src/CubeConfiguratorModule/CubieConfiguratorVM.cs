using RubiksCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeConfiguratorModule
{
    public class CubieConfiguratorVM
    {
        public RubiksCube Cube
        {
            get
            {
                RubiksCube cube = new RubiksCube(null);
                cube.Shuffle();
                return cube;
            }
        }
    }
}
