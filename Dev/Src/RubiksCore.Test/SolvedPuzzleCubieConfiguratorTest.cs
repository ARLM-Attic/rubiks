using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RubiksCore.Test
{
    [TestClass]
    public class SolvedPuzzleCubieConfiguratorTest
    {
        [TestMethod]
        public void CreateCubies_WhenTheNumberOfSidesIsThree_ThenItReturnsCubiesInASolvedState()
        {
            //setup
            SolvedPuzzleCubieConfigurator configurator = new SolvedPuzzleCubieConfigurator();

            //exercise
            IEnumerable<Cubie> cubies = configurator.CreateCubies(3);

            //verification
            Assert.AreEqual<int>(27, cubies.Count());

            Cubie cubie000 = new Cubie
                (
                    frontSide: null,
                    backSide: RubiksColor.Green,
                    rightSide: null,
                    leftSide: RubiksColor.Yellow,
                    upSide: null,
                    downSide: RubiksColor.Orange,
                    postion:
                        new Position()
                            {
                                X = 0,
                                Y = 0,
                                Z = 0
                            }
                );

            Cubie cubie100 = new Cubie
                (
                    frontSide: null,
                    backSide: RubiksColor.Green,
                    rightSide: null,
                    leftSide: null,
                    upSide: null,
                    downSide: RubiksColor.Orange,
                    postion:
                        new Position()
                        {
                            X = 1,
                            Y = 0,
                            Z = 0
                        }
                );

            Cubie cubie200 = new Cubie
                (
                    frontSide: null,
                    backSide: RubiksColor.Green,
                    rightSide: RubiksColor.White,
                    leftSide: null,
                    upSide: null,
                    downSide: RubiksColor.Orange,
                    postion:
                        new Position()
                            {
                                X = 2,
                                Y = 0,
                                Z = 0
                            }
                );

            Cubie cubie010 = new Cubie
                (
                    frontSide: null,
                    backSide: RubiksColor.Green,
                    rightSide: null,
                    leftSide: RubiksColor.Yellow,
                    upSide: null,
                    downSide: RubiksColor.Orange,
                    postion:
                        new Position()
                            {
                                X = 0,
                                Y = 1,
                                Z = 0
                            }
                );

            Cubie cubie110 = new Cubie
                (
                    frontSide: null,
                    backSide: RubiksColor.Green,
                    rightSide: null,
                    leftSide: null,
                    upSide: null,
                    downSide: RubiksColor.Orange,
                    postion:
                        new Position()
                            {
                                X = 1,
                                Y = 0,
                                Z = 0
                            }
                );

            Cubie cubie210 = new Cubie
                (
                    frontSide: null,
                    backSide: RubiksColor.Green,
                    rightSide: RubiksColor.White,
                    leftSide: null,
                    upSide: null,
                    downSide: RubiksColor.Orange,
                    postion:
                        new Position()
                            {
                                X = 2,
                                Y = 0,
                                Z = 0
                            }
                );
        }

        [TestMethod]
        public void CreateCubies_WhenTheNumberOfSidesIsNotThree_ThenItThrowsNotSupportedException()
        {
            Assert.Inconclusive();
        }
    }
}
