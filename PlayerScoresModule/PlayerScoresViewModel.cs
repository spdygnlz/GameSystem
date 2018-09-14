using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Prism.Events;
using GameInterfaces;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace David.GameSystem.Modules
{
    [Export]
    public class PlayerScoresViewModel : BindableBase
    {
        public ObservableCollection<PlayerModel> Players { get; set; }            

        private IEventAggregator EventAggregator;
        private PlayerFactory playerFactory;
        private SubscriptionToken playerAddedToken;

        [ImportingConstructor]
        public PlayerScoresViewModel(IEventAggregator eventAggregator, PlayerFactory factory)
        {
            EventAggregator = eventAggregator;
            playerFactory = factory;
            playerAddedToken = EventAggregator.GetEvent<PlayerAdded>().Subscribe(AddPlayer, true);
            Players = new ObservableCollection<PlayerModel>();
        }

        public void AddPlayer(NewPlayerInfo info)
        {
            var player = playerFactory.CreatePlayer(info);
            Players.Add(player);
            RaisePropertyChanged(nameof(Players));
        }
    }
}
