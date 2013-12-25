using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCore
{
    internal class CubeFace
    {
        private Dictionary<RubiksDirection, Position> _startingPointsForVariousFaces = 
            new Dictionary<RubiksDirection,Position>();
        private List<Position> _positions = new List<Position>();

        internal IEnumerable<Position> CubiePositions
        {
            get
            {
                return _positions;
            }
        }

        internal RubiksDirection FaceDirection
        {
            get;
            private set;
        }
        
        internal CubeFace(RubiksDirection direction, int parentCubeSize = 3)
        {
            InitializeStartingPoints(parentCubeSize);
            if(direction == RubiksDirection.Back)
            {
                Position startingPoint = _startingPointsForVariousFaces[direction];

                for(int i = 0; i < parentCubeSize; i++)
                {
                    for(int j = 0; j < parentCubeSize; j++)
                    {
                        _positions.Add(new Position(){X = i, Y = startingPoint.Y, Z = j});
                    }
                }
            }
        }

        private void InitializeStartingPoints(int cubeSize)
        {
            _startingPointsForVariousFaces.Add(RubiksDirection.Back, new Position() { X = 0, Y = 0, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Front, new Position() { X = 0, Y = cubeSize - 1, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Left, new Position() { X = 0, Y = 0, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Right, new Position() { X = cubeSize - 1, Y = 0, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Up, new Position() { X = 0, Y = 0, Z = cubeSize - 1 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Down, new Position() { X = 0, Y = 0, Z = 0 });
        }
    }
}
