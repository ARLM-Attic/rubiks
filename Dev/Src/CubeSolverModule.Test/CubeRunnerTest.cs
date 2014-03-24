using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubiksCore;
using RubiksCore.RubiksAlgorithmToolset;
using Moq;

namespace CubeSolverModule.Test
{
    [TestClass]
    public class CubeRunnerTest
    {
        [TestMethod]
        public void Construct_ThenRunnerStateIsStopped()
        {
            RubiksCube cube = new RubiksCube(null);
            Mock<ICubeSolvingAlgorithm> algMock = new Mock<ICubeSolvingAlgorithm>();

            CubeRunner cubeRunner = new CubeRunner(cube, algMock.Object);

            Assert.AreEqual(cubeRunner.RunnerState, CubeRunnerState.Stopped);
        }

        [TestMethod]
        public void Run_WhenAlgorithmRunsToCompletion_ThenCubeStateGoesToRunningAndThenStopped()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Run_WhenAlgorithmThrowsException_ThenCubeStateGoesToRunningAndThenErrorStateAndRunReturnsFalse()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Run_WhenAlgorithmSolvesCube_ThenRunReturnsTrue()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Run_WhenAlgorithmFailsToSolveCube_ThenRunReturnsFalse()
        {
            Assert.Inconclusive();
        }
    }
}
