using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeSolverModule.Test
{
    [TestClass]
    public class CubeRunnerTest
    {
        [TestMethod]
        public void Construct_ThenRunnerStateIsStopped()
        {
            Assert.Inconclusive();
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
