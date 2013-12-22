using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCore
{
    internal class CubeFace
    {
        internal IEnumerable<Position> CubiePositions
        {
            get;
            private set;
        }

        internal RubiksDirection FaceDirection
        {
            get;
            private set;
        }
        
        internal CubeFace(RubiksDirection direction, int parentCubeSize = 3)
        {

        }
    }
}
