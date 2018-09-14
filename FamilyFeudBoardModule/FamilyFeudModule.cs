using GameInterfaces;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FamilyFeudBoardModule
{
    [Export(typeof(IGameIcon))]
    public class FamilyFeudModule : IGameIcon
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public FamilyFeudModule(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
        }

        public void Initialize()
        {

        }

        public UserControl GetView()
        {
            var view = new FamilyFeudIconView();            
            var viewModel = new FamilyFeudModuleViewModel(_eventAggregator, _regionManager);
            
            view.DataContext = viewModel;

            return view;
        }
    }
}
