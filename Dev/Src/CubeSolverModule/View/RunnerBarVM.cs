using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolverModule.View
{
    public class RunnerBarVM : INotifyPropertyChanged
    {
        #region Instance Variables

        private SolverResult _lastRunsResult;

        #endregion

        #region Properties

        public CubeRunner Runner
        {
            get;
            private set;
        }

        public SolverResult LastRunsResult
        {
            get
            {
                return _lastRunsResult;
            }
            set
            {
                _lastRunsResult = value;

            }
        }

        #endregion

        #region Constructors

        public RunnerBarVM(CubeRunner runner)
        {
            Runner = runner;
        }

        #endregion

        #region INotifyPropertyChanged\\Events

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
