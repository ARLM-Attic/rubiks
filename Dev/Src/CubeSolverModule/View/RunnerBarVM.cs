using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ICommand RunCommand
        {
            get;
            private set;
        }

        #endregion

        #region Constructors

        public RunnerBarVM(CubeRunner runner)
        {
            Runner = runner;
            RunCommand = new RunCommand(runner, this);
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
