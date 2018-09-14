using FamilyFeudGameModule;
using GameInterfaces;
using GameInterfaces.Events;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FamilyFeudBoardModule
{    
    public class FamilyFeudModuleViewModel
    {
        public ICommand StartGame { get; set; }
        private IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;

        public FamilyFeudModuleViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
            StartGame = new DelegateCommand(StartGameAction);
        }

        private void StartGameAction(object obj)
        {
            obj?.ToString();

            // TODO: Clear the main window.  EventAggregator?
            _eventAggregator.GetEvent<ClearShell>().Publish();

            FamilyFeudBoardView board = new FamilyFeudBoardView();

            // Add the view with the board
            var mainRegion = _regionManager.Regions[RegionNames.BaseShell];
            mainRegion.Add(board, "Board");
            mainRegion.Activate(board); // Needed?

            // Get the game module 
            FamilyFeudGameView gameView = new FamilyFeudGameView();
            FamilyFeudGameViewModel viewModel = new FamilyFeudGameViewModel();
            gameView.DataContext = viewModel;

            // Load the Game in the board 
            var boardRegion = _regionManager.Regions[RegionNames.GameWindow];
            boardRegion.Add(gameView, "Game");
            boardRegion.Activate(gameView); // Needed?

            // TODO: Create a view with the regions applicable to the Family Feud game
            // TODO: Teams instead of players?
            // TODO: Add our view with regions
            // TODO: Play or Edit/Create game wizard.  Popup?
            // TODO: Add game Module
            // TODO: Add player Module
            // TODO: Split screens
        }
    }
}
