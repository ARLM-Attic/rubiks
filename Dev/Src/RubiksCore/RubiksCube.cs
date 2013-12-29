﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace RubiksCore
{
    public class RubiksCube
    {
        #region Instance Variables

        private IDictionary<RubiksDirection, CubeFace> _faces;
        private INotationParser _parser = null;
        private IEnumerable<Cubie> _cubies;

        #endregion

        #region Properties

        public Cubie this[int x, int y, int z]
        {
            get
            {
                Position requestedPosition = new Position() { X = x, Y = y, Z = z };

                Cubie cubie = _cubies.FirstOrDefault(cub => cub.Position.Equals(requestedPosition));

                if(cubie == null)
                {
                    throw new InvalidOperationException(string.Format("Could not find requested cube at {0}", requestedPosition));
                }
                else
                {
                    return cubie;
                }
            }
        }

        public Cubie this[Position pos]
        {
            get
            {
                return this[pos.X, pos.Y, pos.Z];
            }
        }

        public IEnumerable<Cubie> Cubies
        {
            get
            {
                return _cubies;
            }
        }

        #endregion

        #region Methods \\ Basic Moves

        public void TurnFront(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            Turn(RubiksDirection.Front, direction);
        }

        public void TurnBack(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            Turn(RubiksDirection.Back, direction);
        }

        public void TurnRight(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            Turn(RubiksDirection.Right, direction);
        }

        public void TurnLeft(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            Turn(RubiksDirection.Left, direction);
        }

        public void TurnUp(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            Turn(RubiksDirection.Up, direction);
        }

        public void TurnDown(TurningDirection direction = TurningDirection.ThreeoClock)
        {
            Turn(RubiksDirection.Down, direction);
        }

        #endregion

        #region Methods \\ Generic Turning Methods

        public void Turn(string turnNotation)
        {
            if(_parser == null)
            {
                throw new NotSupportedException();
            }
            else
            {
                KeyValuePair<RubiksDirection, TurningDirection>[] turns = _parser.ParseNotation(turnNotation);
                foreach(var turn in turns)
                {
                    Turn(turn.Key, turn.Value);
                }
            }
        }

        public void Turn(RubiksDirection side, TurningDirection direction = TurningDirection.ThreeoClock, int numberOfLayersDeep = 0)
        {
            IDictionary<Position, Position> oldNewPositions = _faces[side].Move(direction, numberOfLayersDeep);
            IEnumerable<KeyValuePair<Cubie, Position>> cubieToNewPositionPairs = oldNewPositions.Select
                (pair => new KeyValuePair<Cubie, Position>(this[pair.Key], pair.Value)).ToList();

            foreach (KeyValuePair<Cubie, Position> cubieToNewPositionPair in cubieToNewPositionPairs)
            {
                Cubie cubieToMove = cubieToNewPositionPair.Key;
                switch (side)
                {
                    case RubiksDirection.Front:
                        cubieToMove.Move(cubieToNewPositionPair.Value, Axes.Y, direction);
                        break;
                    case RubiksDirection.Back:
                        cubieToMove.Move(cubieToNewPositionPair.Value, Axes.Y, direction);
                        break;
                    case RubiksDirection.Up:
                        cubieToMove.Move(cubieToNewPositionPair.Value, Axes.Z, direction);
                        break;
                    case RubiksDirection.Down:
                        cubieToMove.Move(cubieToNewPositionPair.Value, Axes.Z, direction);
                        break;
                    case RubiksDirection.Left:
                        cubieToMove.Move(cubieToNewPositionPair.Value, Axes.X, direction);
                        break;
                    case RubiksDirection.Right:
                        cubieToMove.Move(cubieToNewPositionPair.Value, Axes.X, direction);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Constructors

        public RubiksCube(INotationParser parser, int cubeSize = 3)
            : this(parser, new SolvedPuzzleCubieConfigurator(), cubeSize)
        {
            
        }

        internal RubiksCube(INotationParser parser, ICubieConfigurator configurator, int cubeSize)
        {
            _faces = new Dictionary<RubiksDirection, CubeFace>();
            _faces.Add(RubiksDirection.Front, new CubeFace(RubiksDirection.Front, cubeSize));
            _faces.Add(RubiksDirection.Back, new CubeFace(RubiksDirection.Back, cubeSize));
            _faces.Add(RubiksDirection.Up, new CubeFace(RubiksDirection.Up, cubeSize));
            _faces.Add(RubiksDirection.Down, new CubeFace(RubiksDirection.Down, cubeSize));
            _faces.Add(RubiksDirection.Left, new CubeFace(RubiksDirection.Left, cubeSize));
            _faces.Add(RubiksDirection.Right, new CubeFace(RubiksDirection.Right, cubeSize));

            _parser = parser;

            _cubies = new SolvedPuzzleCubieConfigurator().CreateCubies(cubeSize);
        }

        #endregion
    }
}

