using RubiksCore;
using RubiksCore.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolverModule
{
    public class CubeRunner : INotifyPropertyChanged
    {
        #region Instance Variables

        CubeRunnerState _state;
        RubiksCube _cube;
        ICubeSolvingAlgorithm _alg;

        #endregion

        #region Constructors

        internal CubeRunner(RubiksCube cube, ICubeSolvingAlgorithm algorithm)
        {
            _cube = cube;
            _alg = algorithm;

            _state = CubeRunnerState.Stopped;
        } 

        #endregion

        #region Properties

        /// <summary>
        /// Represents the current state of the runner
        /// </summary>
        public CubeRunnerState RunnerState
        {
            get
            {
                return _state;
            }
            private set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged("RunnerState");
                }
            }
        } 

        #endregion

        #region Methods

        /// <summary>
        /// Runs the algorithm.
        /// </summary>
        /// <returns>The results of the run</returns>
        public SolverResult Run()
        {
            RunnerState = CubeRunnerState.Running;

            SolverResult result = new SolverResult();

            RunnerState = CubeRunnerState.Stopped;

            return result;
        } 

        #endregion

        #region INotifyPropertyChanged\\Events

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        } 

        #endregion
    }
}
