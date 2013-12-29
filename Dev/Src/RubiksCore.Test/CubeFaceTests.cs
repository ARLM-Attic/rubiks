﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RubiksCore.Test
{
    [TestClass]
    public class CubeFaceTests
    {
        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsTwoAndDirectionIsBack_ThenCubiePositionsAreAccurate()
        {
            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            Position position000 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position000);
            Position position100 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position100);
            Position position001 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position001);
            Position position101 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position101);

            //exercise
            CubeFace face = new CubeFace(RubiksDirection.Back, 2);

            //verification
            Assert.IsTrue(expectedPositions.SetEquals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsTwoAndDirectionIsRight_ThenCubiePositionsAreAccurate()
        {
            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            Position position100 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position100);
            Position position110 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 0
            };
            expectedPositions.Add(position110);
            Position position101 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position101);
            Position position111 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position111);

            //exercise
            CubeFace face = new CubeFace(RubiksDirection.Right, 2);

            //verification
            Assert.IsTrue(expectedPositions.SetEquals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsTwoAndDirectionIsUp_ThenCubiePositionsAreAccurate()
        {
            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            Position position001 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position001);
            Position position101 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position101);
            Position position011 = new Position()
            {
                X = 0,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position011);
            Position position111 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position111);

            //exercise
            CubeFace face = new CubeFace(RubiksDirection.Up, 2);

            //verification
            Assert.IsTrue(expectedPositions.SetEquals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsThreeAndDirectionIsBack_ThenCubiePositionsAreAccurate()
        {
            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            Position position000 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position000);

            Position position100 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position100);

            Position position200 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position200);

            Position position001 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position001);

            Position position101 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position101);

            Position position201 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position201);

            Position position002 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position002);

            Position position102 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position102);

            Position position202 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position202);

            //exercise
            CubeFace face = new CubeFace(RubiksDirection.Back, 3);

            //verification
            Assert.IsTrue(expectedPositions.SetEquals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsThreeAndDirectionIsRight_ThenCubiePositionsAreAccurate()
        {
            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            Position position200 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position200);

            Position position210 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 0
            };
            expectedPositions.Add(position210);

            Position position220 = new Position()
            {
                X = 2,
                Y = 2,
                Z = 0
            };
            expectedPositions.Add(position220);

            Position position201 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position201);

            Position position211 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position211);

            Position position221 = new Position()
            {
                X = 2,
                Y = 2,
                Z = 1
            };
            expectedPositions.Add(position221);

            Position position202 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position202);

            Position position212 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position212);

            Position position222 = new Position()
            {
                X = 2,
                Y = 2,
                Z = 2
            };
            expectedPositions.Add(position222);

            //exercise
            CubeFace face = new CubeFace(RubiksDirection.Right, 3);

            //verification
            Assert.IsTrue(expectedPositions.SetEquals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsThreeAndDirectionIsUp_ThenCubiePositionsAreAccurate()
        {
            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            Position position002 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position002);

            Position position012 = new Position()
            {
                X = 0,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position012);

            Position position022 = new Position()
            {
                X = 0,
                Y = 2,
                Z = 2
            };
            expectedPositions.Add(position022);

            Position position102 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position102);

            Position position112 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position112);

            Position position122 = new Position()
            {
                X = 1,
                Y = 2,
                Z = 2
            };
            expectedPositions.Add(position122);

            Position position202 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position202);

            Position position212 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position212);

            Position position222 = new Position()
            {
                X = 2,
                Y = 2,
                Z = 2
            };
            expectedPositions.Add(position222);

            //exercise
            CubeFace face = new CubeFace(RubiksDirection.Up, 3);

            //verification
            Assert.IsTrue(expectedPositions.SetEquals(face.CubiePositions));
        }

        [TestMethod]
        public void GetPositionsOfLayersBeneathFace_WhenNumberOfLayersDeepIsZero_ThenCubiePositionsAreEqualToPositionsOfFace()
        {
            //setup
            CubeFace face = new CubeFace(RubiksDirection.Front);

            //exercise
            IEnumerable<Position> positions = face.GetPositionsOfLayersBeneathFace(0);

            //verification
            Assert.IsTrue(new HashSet<Position>(face.CubiePositions).SetEquals(positions));
        }

        [TestMethod]
        public void GetPositionsOfLayersBeneathFace_WhenNumberOfLayersDeepIsOne_ThenCubiePositionsIncludePositionsOfFacePlusOneLayerBeneathIt()
        {
            //setup
            CubeFace face = new CubeFace(RubiksDirection.Back);

            //setup
            HashSet<Position> expectedPositions = new HashSet<Position>();

            //layer one
            Position position000 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position000);

            Position position100 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position100);

            Position position200 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 0
            };
            expectedPositions.Add(position200);

            Position position001 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position001);

            Position position101 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position101);

            Position position201 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 1
            };
            expectedPositions.Add(position201);

            Position position002 = new Position()
            {
                X = 0,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position002);

            Position position102 = new Position()
            {
                X = 1,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position102);

            Position position202 = new Position()
            {
                X = 2,
                Y = 0,
                Z = 2
            };
            expectedPositions.Add(position202);

            //layer two
            Position position010 = new Position()
            {
                X = 0,
                Y = 1,
                Z = 0
            };
            expectedPositions.Add(position010);

            Position position110 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 0
            };
            expectedPositions.Add(position110);

            Position position210 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 0
            };
            expectedPositions.Add(position210);

            Position position011 = new Position()
            {
                X = 0,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position011);

            Position position111 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position111);

            Position position211 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 1
            };
            expectedPositions.Add(position211);

            Position position012 = new Position()
            {
                X = 0,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position012);

            Position position112 = new Position()
            {
                X = 1,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position112);

            Position position212 = new Position()
            {
                X = 2,
                Y = 1,
                Z = 2
            };
            expectedPositions.Add(position212);
            //exercise
            IEnumerable<Position> positions = face.GetPositionsOfLayersBeneathFace(1);

            Assert.AreEqual<int>(18, positions.Count());
            Assert.IsTrue(expectedPositions.SetEquals(positions));
        }

        [TestMethod]
        public void Move_WhenFaceIsFrontAndLayersDeepIsZero_ThenFrontFacePositionsMoved()
        {
            CubeFace frontFace = new CubeFace(RubiksDirection.Front);

            IDictionary<Position, Position> positions = frontFace.Move(TurningDirection.ThreeoClock);

            Dictionary<Position, Position> expectedPositions = new Dictionary<Position,Position>();
            expectedPositions.Add(new Position() { X = 0, Y = 2, Z = 0 }, new Position() { X = 0, Y = 2, Z = 2 });
            expectedPositions.Add(new Position() { X = 0, Y = 2, Z = 1 }, new Position() { X = 1, Y = 2, Z = 2 });
            expectedPositions.Add(new Position() { X = 0, Y = 2, Z = 2 }, new Position() { X = 2, Y = 2, Z = 2 });
            expectedPositions.Add(new Position() { X = 1, Y = 2, Z = 0 }, new Position() { X = 0, Y = 2, Z = 1 });
            expectedPositions.Add(new Position() { X = 1, Y = 2, Z = 2 }, new Position() { X = 2, Y = 2, Z = 1 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 0 }, new Position() { X = 0, Y = 2, Z = 0 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 1 }, new Position() { X = 1, Y = 2, Z = 0 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 2 }, new Position() { X = 2, Y = 2, Z = 0 });
            HashSet<KeyValuePair<Position, Position>> expectedPositionsHashSet = new HashSet<KeyValuePair<Position, Position>>(expectedPositions.ToList());

            Assert.IsTrue(expectedPositionsHashSet.SetEquals(positions));
        }

        [TestMethod]
        public void Move_WhenFaceIsUpAndLayersDeepIsZero_ThenUpFacePositionsMoved()
        {
            CubeFace upFace = new CubeFace(RubiksDirection.Up);

            IDictionary<Position, Position> positions = upFace.Move(TurningDirection.ThreeoClock);

            Dictionary<Position, Position> expectedPositions = new Dictionary<Position, Position>();
            expectedPositions.Add(new Position() { X = 0, Y = 0, Z = 2 }, new Position() { X = 2, Y = 0, Z = 2 });
            expectedPositions.Add(new Position() { X = 1, Y = 0, Z = 2 }, new Position() { X = 2, Y = 1, Z = 2 });
            expectedPositions.Add(new Position() { X = 2, Y = 0, Z = 2 }, new Position() { X = 2, Y = 2, Z = 2 });
            expectedPositions.Add(new Position() { X = 0, Y = 1, Z = 2 }, new Position() { X = 1, Y = 0, Z = 2 });
            expectedPositions.Add(new Position() { X = 2, Y = 1, Z = 2 }, new Position() { X = 1, Y = 2, Z = 2 });
            expectedPositions.Add(new Position() { X = 0, Y = 2, Z = 2 }, new Position() { X = 0, Y = 0, Z = 2 });
            expectedPositions.Add(new Position() { X = 1, Y = 2, Z = 2 }, new Position() { X = 0, Y = 1, Z = 2 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 2 }, new Position() { X = 0, Y = 2, Z = 2 });
            HashSet<KeyValuePair<Position, Position>> expectedPositionsHashSet = new HashSet<KeyValuePair<Position, Position>>(expectedPositions.ToList());

            Assert.IsTrue(expectedPositionsHashSet.SetEquals(positions));
        }

        [TestMethod]
        public void Move_WhenFaceIsRightAndLayersDeepIsZero_ThenUpFacePositionsMoved()
        {
            CubeFace upFace = new CubeFace(RubiksDirection.Right);

            IDictionary<Position, Position> positions = upFace.Move(TurningDirection.ThreeoClock);

            Dictionary<Position, Position> expectedPositions = new Dictionary<Position, Position>();
            expectedPositions.Add(new Position() { X = 2, Y = 0, Z = 0 }, new Position() { X = 2, Y = 2, Z = 0 });
            expectedPositions.Add(new Position() { X = 2, Y = 1, Z = 0 }, new Position() { X = 2, Y = 2, Z = 1 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 0 }, new Position() { X = 2, Y = 2, Z = 2 });
            expectedPositions.Add(new Position() { X = 2, Y = 0, Z = 1 }, new Position() { X = 2, Y = 1, Z = 0 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 1 }, new Position() { X = 2, Y = 1, Z = 2 });
            expectedPositions.Add(new Position() { X = 2, Y = 0, Z = 2 }, new Position() { X = 2, Y = 0, Z = 0 });
            expectedPositions.Add(new Position() { X = 2, Y = 1, Z = 2 }, new Position() { X = 2, Y = 0, Z = 1 });
            expectedPositions.Add(new Position() { X = 2, Y = 2, Z = 2 }, new Position() { X = 2, Y = 0, Z = 2 });
            HashSet<KeyValuePair<Position, Position>> expectedPositionsHashSet = new HashSet<KeyValuePair<Position, Position>>(expectedPositions.ToList());

            Assert.IsTrue(expectedPositionsHashSet.SetEquals(positions));
        }
    }
}