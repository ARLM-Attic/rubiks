using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCore
{
    internal class CubeFace
    {
        #region Instance Variables

        private Dictionary<RubiksDirection, Position> _startingPointsForVariousFaces =
            new Dictionary<RubiksDirection, Position>();
        private List<Position> _positions = new List<Position>(); 

        #endregion

        #region Properties

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

        #endregion

        #region Constructors

        internal CubeFace(RubiksDirection direction, int parentCubeSize = 3)
        {
            FaceDirection = direction;
            InitializeStartingPoints(parentCubeSize);
            InitializeCubiePositions(parentCubeSize);
        } 

        #endregion

        #region Methods\\Helpers

        private void InitializeStartingPoints(int cubeSize)
        {
            _startingPointsForVariousFaces.Add(RubiksDirection.Back, new Position() { X = 0, Y = 0, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Front, new Position() { X = 0, Y = cubeSize - 1, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Left, new Position() { X = 0, Y = 0, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Right, new Position() { X = cubeSize - 1, Y = 0, Z = 0 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Up, new Position() { X = 0, Y = 0, Z = cubeSize - 1 });
            _startingPointsForVariousFaces.Add(RubiksDirection.Down, new Position() { X = 0, Y = 0, Z = 0 });

        }

        private void InitializeCubiePositions(int parentCubeSize)
        {
            List<Axes> includedAxes = new List<Axes>();

            switch (FaceDirection)
            {
                case RubiksDirection.Front:
                    includedAxes.Add(Axes.X);
                    includedAxes.Add(Axes.Z);
                    break;
                case RubiksDirection.Back:
                    includedAxes.Add(Axes.X);
                    includedAxes.Add(Axes.Z);
                    break;
                case RubiksDirection.Up:
                    includedAxes.Add(Axes.X);
                    includedAxes.Add(Axes.Y);
                    break;
                case RubiksDirection.Down:
                    includedAxes.Add(Axes.X);
                    includedAxes.Add(Axes.Y);
                    break;
                case RubiksDirection.Left:
                    includedAxes.Add(Axes.Y);
                    includedAxes.Add(Axes.Z);
                    break;
                case RubiksDirection.Right:
                    includedAxes.Add(Axes.Y);
                    includedAxes.Add(Axes.Z);
                    break;
                default:
                    break;
            }

            Position startingPoint = _startingPointsForVariousFaces[FaceDirection];

            for (int i = 0; i < parentCubeSize; i++)
            {
                for (int j = 0; j < parentCubeSize; j++)
                {
                    Queue<int> coordinates = new Queue<int>();
                    coordinates.Enqueue(i);
                    coordinates.Enqueue(j);
                    Position position = new Position();

                    if (includedAxes.Contains(Axes.X))
                    {
                        position.X = coordinates.Dequeue();
                    }
                    else
                    {
                        position.X = startingPoint.X;
                    }
                    if (includedAxes.Contains(Axes.Y))
                    {
                        position.Y = coordinates.Dequeue();
                    }
                    else
                    {
                        position.Y = startingPoint.Y;
                    }
                    if (includedAxes.Contains(Axes.Z))
                    {
                        position.Z = coordinates.Dequeue();
                    }
                    else
                    {
                        position.Z = startingPoint.Z;
                    }
                    _positions.Add(position);
                }
            }
        } 

        #endregion

        #region Enums

        enum Axes
        {
            X,
            Y,
            Z
        } 

        #endregion
    }
}
