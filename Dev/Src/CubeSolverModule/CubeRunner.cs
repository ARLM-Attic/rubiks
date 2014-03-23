﻿using RubiksCore;
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

        #endregion

        #region Constructors

        internal CubeRunner(RubiksCube cube, ICubeSolvingAlgorithm algorithm)
        {
            throw new NotImplementedException();
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
        /// <returns>True if the cube is solved and false if it is not</returns>
        public bool Run()
        {
            throw new NotImplementedException();
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