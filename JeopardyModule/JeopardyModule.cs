using GameInterfaces;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace David.GameSystem.Modules
{
    [ModuleExport(typeof(JeopardyModule), InitializationMode = InitializationMode.WhenAvailable)]
    //[Module]
    public class JeopardyModule : IModule
    {
        public void Initialize()
        {
            //var view = ServiceLocator.Current.GetInstance<JeopardyModuleView>();
            //var viewModel = ServiceLocator.Current.GetInstance<JeopadyModuleViewModel>();
            //view.DataContext = viewModel;
            
            //IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();

            //// TODO: Possible alternat method
            ////regionManager.RegisterViewWithRegion(GameInterfaces.RegionNames.MainContent, typeof(JeopardyModuleView));

            //// Add the view to the region
            //IRegion mainRegion = regionManager.Regions[GameInterfaces.RegionNames.MainContent];
            //mainRegion.Add(view);
        }
    }

    [Export(typeof(IGameIcon))]
    public class JeopardyMiniModule : IGameIcon
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public JeopardyMiniModule(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //var view = ServiceLocator.Current.GetInstance<JeopardyModuleView>();
            //var viewModel = ServiceLocator.Current.GetInstance<JeopadyModuleViewModel>();
            //view.DataContext = viewModel;

            //IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();

            //// Add the view to the region
            //IRegion mainRegion = regionManager.Regions[GameInterfaces.RegionNames.MainContent];
            //mainRegion.Add(view);
        }

        public UserControl GetView()
        {
            var view = new JeopardyModuleView();
            var viewModel = new JeopadyModuleViewModel(_eventAggregator, _regionManager);

            view.DataContext = viewModel;

            return view;
        }
    }
}
