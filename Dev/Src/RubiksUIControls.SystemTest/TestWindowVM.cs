using RubiksCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksUIControls.SystemTest
{
    class TestWindowVM
    {
        private RubiksCube _cube = new RubiksCube(null, 3);

        public RubiksCube RubiksCube
        {
            get
            {
                return _cube;
            }
        }
    }
}
