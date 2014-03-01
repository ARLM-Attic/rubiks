using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeConfiguratorModule
{
    public class CubeConfiguratorModule : IModule
    {
        readonly IRegionViewRegistry _viewRegistry;

        public CubeConfiguratorModule(IRegionViewRegistry viewRegistry)
        {
            _viewRegistry = viewRegistry;
        }

        public void Initialize()
        {
            _viewRegistry.RegisterViewWithRegion("cubeConfigurator", typeof(CubeConfiguratorControl));
        }
    }
}
