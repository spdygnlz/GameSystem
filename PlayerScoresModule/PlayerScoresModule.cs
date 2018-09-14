using Prism.Modularity;
using Prism.Mef.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Prism.Regions;

namespace David.GameSystem.Modules
{
    [ModuleExport(typeof(PlayerScoresModule), InitializationMode = InitializationMode.WhenAvailable)]
    //[Module]
    public class PlayerScoresModule : IModule
    {

        public void Initialize()
        {
            var view = ServiceLocator.Current.GetInstance<PlayerScoresView>();
            var viewModel = ServiceLocator.Current.GetInstance<PlayerScoresViewModel>();

            view.DataContext = viewModel;

            IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();

            IRegion mainRegion = regionManager.Regions[GameInterfaces.RegionNames.PlayersContent];
            mainRegion.Add(view);
        }
    }
}
