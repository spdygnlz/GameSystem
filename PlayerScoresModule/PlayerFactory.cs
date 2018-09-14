using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Prism.Events;
using GameInterfaces;
using Microsoft.Practices.ServiceLocation;

namespace David.GameSystem.Modules
{
    [Export]
    public class PlayerFactory
    {
        public PlayerModel CreatePlayer(NewPlayerInfo info)
        {
            var player = ServiceLocator.Current.GetInstance<PlayerModel>();
            player.FirstName = info.FirstName;
            player.LastName = info.LastName;
            player.Id = info.Id;

            return player;
        }
    }
}
