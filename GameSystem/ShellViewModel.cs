using GameInterfaces;
using Prism.Mvvm;
using Prism.Regions;
using System.ComponentModel.Composition;
using Prism.Events;
using GameInterfaces.Events;

namespace GameSystem
{
    [Export]
    public class ShellViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator;
        private IRegion _mainRegion;

        [ImportingConstructor]
        public ShellViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _mainRegion = regionManager.Regions[RegionNames.BaseShell];

            GameSelectionView gameSelectionView = new GameSelectionView();
            GameSelectionViewModel viewModel = new GameSelectionViewModel();
            gameSelectionView.DataContext = viewModel;

            _mainRegion.Add(gameSelectionView, "GameSelectionView");
            _mainRegion.Activate(gameSelectionView); // Needed?       

            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<ClearShell>().Subscribe(ClearShellAction);
        }

        private void ClearShellAction()
        {
            _mainRegion.RemoveAll();
        }
    }
}
