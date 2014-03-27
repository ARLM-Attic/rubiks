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
            RubiksCube cube = new RubiksCube();
            Mock<ICubeSolvingAlgorithm> algMock = new Mock<ICubeSolvingAlgorithm>();

            CubeRunner cubeRunner = new CubeRunner(cube, algMock.Object);

            Assert.AreEqual(cubeRunner.RunnerState, CubeRunnerState.Stopped);
        }

        [TestMethod]
        public void Run_WhenAlgorithmRunsToCompletion_ThenCubeStateGoesToRunningAndThenStopped()
        {
            RubiksCube cube = new RubiksCube();
            Mock<ICubeSolvingAlgorithm> algMock = new Mock<ICubeSolvingAlgorithm>();

            CubeRunner cubeRunner = new CubeRunner(cube, algMock.Object);

            bool wentToRunning = false;
            bool wentToStopped = false;
            cubeRunner.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler((sender, args) => 
            {
                if(cubeRunner.RunnerState == CubeRunnerState.Running)
                {
                    wentToRunning = true;
                }
                if(cubeRunner.RunnerState == CubeRunnerState.Stopped)
                {
                    wentToStopped = true;
                }
            });

            cubeRunner.Run();

            Assert.IsTrue(wentToRunning && wentToStopped);
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
