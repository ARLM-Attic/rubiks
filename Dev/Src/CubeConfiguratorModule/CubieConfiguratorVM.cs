using Microsoft.Practices.Prism.Commands;
using RubiksCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CubeConfiguratorModule
{
    public class CubieConfiguratorVM
    {
        ICommand _hotkeyCommand;

        public CubieConfiguratorVM()
        {
            RubiksCube cube = new RubiksCube(null);
            cube.Shuffle();
            Cube = cube;

            _hotkeyCommand = new CubeManipulationCommand(Cube);
        }

        public RubiksCube Cube
        {
            get;
            private set;
        }

        public ICommand CubeManipulationCommand
        {
            get
            {
                return _hotkeyCommand;
            }
        }
    }
}
