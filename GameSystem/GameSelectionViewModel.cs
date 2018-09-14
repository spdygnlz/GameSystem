using GameInterfaces;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Microsoft.Practices.ServiceLocation;
using System.Windows.Controls;

namespace GameSystem
{
    [Export]
    public class GameSelectionViewModel : BindableBase
    {
        public ObservableCollection<UserControl> Icons { get; set; }

        [ImportingConstructor]
        public GameSelectionViewModel()
        {
            Icons = new ObservableCollection<UserControl>();
            var modules = ServiceLocator.Current.GetAllInstances<IGameIcon>();
            foreach(var module in modules)
            {
                module.Initialize();
                Icons.Add(module.GetView());
            }
        }
    }
}
