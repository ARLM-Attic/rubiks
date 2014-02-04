using RubiksCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksUIControls
{
    public static class RubiksCubeExtensions
    {
        private static Dictionary<TwoDPosition, Position> _positionMappings =
            new Dictionary<TwoDPosition, Position>()
            {
                {new TwoDPosition(3, 8), new Position(0,0,0)},
                {new TwoDPosition(0, 5), new Position(0,0,0)},
                {new TwoDPosition(11, 5), new Position(0,0,0)}
            };

        private static Dictionary<TwoDPosition, RubiksDirection> _positionFaceMappings =
            new Dictionary<TwoDPosition, RubiksDirection>()
            {
                {new TwoDPosition(3, 8), RubiksDirection.Down},
                {new TwoDPosition(0, 5), RubiksDirection.Left},
                {new TwoDPosition(11, 5), RubiksDirection.Back}
            };

        public static Color GetColor(this RubiksCube cube, TwoDPosition pos)
        {
            if(cube.CubeSize != 3)
            {
                throw new NotSupportedException("Currently we only draw 3x3x3 cubes two dimensionally :(");
            }

            Position threeDPosition = default(Position);
            RubiksDirection direction = default(RubiksDirection);
            if(_positionFaceMappings.ContainsKey(pos) && _positionMappings.ContainsKey(pos))
            {
                threeDPosition = _positionMappings[pos];
                direction = _positionFaceMappings[pos];
            }
            

            RubiksColor? positionColor = cube[threeDPosition].GetColor(direction);

            if(positionColor == null)
            {
                //oops
                return Colors.Black;
            }

            switch (positionColor.Value)
            {
                case RubiksColor.Blue:
                    return Colors.Blue;
                case RubiksColor.Green:
                    return Colors.Green;
                case RubiksColor.Orange:
                    return Colors.Orange;
                case RubiksColor.Red:
                    return Colors.Red;
                case RubiksColor.White:
                    return Colors.White;
                case RubiksColor.Yellow:
                    return Colors.Yellow;
                default:
                    return Colors.Black;
            }
        }
    }
}
