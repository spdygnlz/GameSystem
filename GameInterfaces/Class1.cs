using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameInterfaces
{
    public interface IGame
    {
        string GameName { get; }
        void StartGame();
    }

    public static class RegionNames
    {
        public const string MainContent = "MainContent";
        public const string PlayersContent = "PlayersContent";
        public const string BaseShell = "BaseShell";
        public const string GameWindow = "GameWindow";
    }

    public interface IGameIcon
    {
        void Initialize();
        UserControl GetView();
    }
}
