using Prism.Mvvm;
using Prism.Regions;
using Prism.Events;
using System.ComponentModel.Composition;
using System.Windows.Input;
using GameInterfaces;
using GameInterfaces.Events;
using Game1;
using Microsoft.Practices.ServiceLocation;
using Game1.Windows;

namespace David.GameSystem.Modules
{
    [Export]
    public class JeopadyModuleViewModel : BindableBase
    {
        public ICommand AddPlayer { get; set; }
        public ICommand StartGame { get; set; }
        private IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public JeopadyModuleViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;

            AddPlayer = new DelegateCommand(AddPlayerAction);
            StartGame = new DelegateCommand(StartGameAction);
        }

        public void AddPlayerAction(object data)
        {            
            var window = new AddPlayerWindow();
            window.ShowDialog();

            if (!window.IsCanceled)
            {
                var info = new NewPlayerInfo()
                {
                    FirstName = window.FirstName,
                    LastName = window.LastName,
                    Id = window.Id
                };

                _eventAggregator.GetEvent<PlayerAdded>().Publish(info);
            }            
        }

        private void StartGameAction(object obj)
        {
            obj?.ToString();

            // TODO: Clear the main window.  EventAggregator?
            _eventAggregator.GetEvent<ClearShell>().Publish();

            JeopardyBoardView board = new JeopardyBoardView();            

            // Add the view with the board
            var mainRegion = _regionManager.Regions[RegionNames.BaseShell];
            mainRegion.Add(board, "Board");
            mainRegion.Activate(board); // Needed?

            // Get the game module             
            //PlayMainControl gameView = new PlayMainControl();
            //JeopardyGameView gameView = new JeopardyGameView();
            IntroductionWindow gameView2 = new IntroductionWindow();
            gameView2.Show();
            
            // Load the Game in the board 
            //var boardRegion = _regionManager.Regions[RegionNames.GameWindow];
            //boardRegion.Add(gameView);
            //boardRegion.Activate(gameView); // Needed?            

            // Get the players module
            var player = ServiceLocator.Current.GetInstance<PlayerScoresView>();
            var playerRegion = _regionManager.Regions[RegionNames.PlayersContent];
            playerRegion.Add(player);
            playerRegion.Activate(player);


            // TODO: Create a view with the regions applicable to the Family Feud game           
            // TODO: Add our view with regions
            // TODO: Play or Edit/Create game wizard.  Popup?
            // TODO: Add game Module
            // TODO: Add player Module
            // TODO: Split screens
        }

    }
}
