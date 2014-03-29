using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeSolverModule.View;

namespace CubeSolverModule
{
    [Module(ModuleName="CubeSolverModule")]
    [ModuleDependency("CubeConfiguratorModule")]
    public class CubeSolverModule : IModule
    {
        IRegionViewRegistry _viewRegistry;

        public CubeSolverModule(IRegionViewRegistry viewRegistry)
        {
            _viewRegistry = viewRegistry;
        }
        public void Initialize()
        {
            _viewRegistry.RegisterViewWithRegion("solver", typeof(CubeRunnerView));
        }
    }
}
