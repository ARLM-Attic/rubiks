using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RubiksCore.Test
{
    [TestClass]
    public class CubieTests
    {
        [TestMethod]
        public void Move_WhenAxisOfRotationIsYAndDirectionIs3oClock_ThenTheAppropriateFaceAreShifted()
        {
            Cubie cubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: RubiksColor.Blue,
                        downSide: null,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 3,
                                Z = 3
                            }
                    );

            cubie.Move(new Position() { X = 3, Y = 3, Z = 0 }, Axes.Y, TurningDirection.ThreeoClock);

            Cubie expectedCubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: RubiksColor.Blue,
                        leftSide: null,
                        upSide: null,
                        downSide: RubiksColor.Red,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 3,
                                Z = 0
                            }
                    );

            Assert.AreEqual<Cubie>(expectedCubie, cubie);
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsYAndDirectionIs6oClock_ThenTheAppropriateFaceAreShifted()
        {
            Cubie cubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: RubiksColor.Blue,
                        downSide: null,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 3,
                                Z = 3
                            }
                    );

            cubie.Move(new Position() { X = 0, Y = 3, Z = 0 }, Axes.Y, TurningDirection.SixoClock);

            Cubie expectedCubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: null,
                        leftSide: RubiksColor.Red,
                        upSide: null,
                        downSide: RubiksColor.Blue,
                        postion:
                            new Position()
                            {
                                X = 0,
                                Y = 3,
                                Z = 0
                            }
                    );

            Assert.AreEqual<Cubie>(expectedCubie, cubie);
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsYAndDirectionIs9oClock_ThenTheAppropriateFaceAreShifted()
        {
            Cubie cubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: RubiksColor.Blue,
                        downSide: null,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 3,
                                Z = 3
                            }
                    );

            cubie.Move(new Position() { X = 0, Y = 3, Z = 3 }, Axes.Y, TurningDirection.NineoClock);

            Cubie expectedCubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: null,
                        leftSide: RubiksColor.Blue,
                        upSide: RubiksColor.Red,
                        downSide: null,
                        postion:
                            new Position()
                            {
                                X = 0,
                                Y = 3,
                                Z = 3
                            }
                    );

            Assert.AreEqual<Cubie>(expectedCubie, cubie);
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsXAndDirectionIs3oClock_ThenTheAppropriateFaceAreShifted()
        {
            Cubie cubie = new Cubie
                    (
                        frontSide: RubiksColor.White,
                        backSide: null,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: RubiksColor.Blue,
                        downSide: null,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 3,
                                Z = 3
                            }
                    );

            cubie.Move(new Position() { X = 3, Y = 0, Z = 3 }, Axes.X, TurningDirection.ThreeoClock);

            Cubie expectedCubie = new Cubie
                    (
                        frontSide: null,
                        backSide: RubiksColor.Blue,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: RubiksColor.White,
                        downSide: null,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 0,
                                Z = 3
                            }
                    );

            Assert.AreEqual<Cubie>(expectedCubie, cubie);
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsXAndDirectionIs6oClock_ThenTheAppropriateFaceAreShifted()
        {
            Cubie cubie = new Cubie
                       (
                           frontSide: RubiksColor.White,
                           backSide: null,
                           rightSide: RubiksColor.Red,
                           leftSide: null,
                           upSide: RubiksColor.Blue,
                           downSide: null,
                           postion:
                               new Position()
                               {
                                   X = 3,
                                   Y = 3,
                                   Z = 3
                               }
                       );

            cubie.Move(new Position() { X = 3, Y = 0, Z = 0 }, Axes.X, TurningDirection.SixoClock);

            Cubie expectedCubie = new Cubie
                    (
                        frontSide: null,
                        backSide: RubiksColor.White,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: null,
                        downSide: RubiksColor.Blue,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 0,
                                Z = 0
                            }
                    );

            Assert.AreEqual<Cubie>(expectedCubie, cubie);
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsXAndDirectionIs9oClock_ThenTheAppropriateFaceAreShifted()
        {
            Cubie cubie = new Cubie
                       (
                           frontSide: RubiksColor.White,
                           backSide: null,
                           rightSide: RubiksColor.Red,
                           leftSide: null,
                           upSide: RubiksColor.Blue,
                           downSide: null,
                           postion:
                               new Position()
                               {
                                   X = 3,
                                   Y = 3,
                                   Z = 3
                               }
                       );

            cubie.Move(new Position() { X = 3, Y = 3, Z = 0 }, Axes.X, TurningDirection.NineoClock);

            Cubie expectedCubie = new Cubie
                    (
                        frontSide: RubiksColor.Blue,
                        backSide: null,
                        rightSide: RubiksColor.Red,
                        leftSide: null,
                        upSide: null,
                        downSide: RubiksColor.White,
                        postion:
                            new Position()
                            {
                                X = 3,
                                Y = 3,
                                Z = 0
                            }
                    );

            Assert.AreEqual<Cubie>(expectedCubie, cubie);
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsZAndDirectionIs3oClock_ThenTheAppropriateFaceAreShifted()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsZAndDirectionIs6oClock_ThenTheAppropriateFaceAreShifted()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Move_WhenAxisOfRotationIsZAndDirectionIs9oClock_ThenTheAppropriateFaceAreShifted()
        {
            Assert.Inconclusive();
        }
    }
}
