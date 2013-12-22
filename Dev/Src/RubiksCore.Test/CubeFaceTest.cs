using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RubiksCore.Test
{
    [TestClass]
    public class CubeFaceTest
    {
        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsTwoAndDirectionIsBack_ThenCubiePositionsAreAccurate()
        {
            //setup
            List<Position> expectedPositions = new List<Position>();

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
            Assert.IsTrue(expectedPositions.Equals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsTwoAndDirectionIsRight_ThenCubiePositionsAreAccurate()
        {
            //setup
            List<Position> expectedPositions = new List<Position>();

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
            Assert.IsTrue(expectedPositions.Equals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsTwoAndDirectionIsUp_ThenCubiePositionsAreAccurate()
        {
            //setup
            List<Position> expectedPositions = new List<Position>();

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
            Assert.IsTrue(expectedPositions.Equals(face.CubiePositions));
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsThreeAndDirectionIsBack_ThenCubiePositionsAreAccurate()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsThreeAndDirectionIsRight_ThenCubiePositionsAreAccurate()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsThreeAndDirectionIsTop_ThenCubiePositionsAreAccurate()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsFourAndDirectionIsBack_ThenCubiePositionsAreAccurate()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsFourAndDirectionIsRight_ThenCubiePositionsAreAccurate()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InitializeCubeFace_WhenCubeSizeIsFourAndDirectionIsTop_ThenCubiePositionsAreAccurate()
        {
            Assert.Inconclusive();
        }
    }
}
