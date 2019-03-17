using Game1.Events;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        public string Icon { get; set; }
        public int ButtonId { get; set; }

        public UserViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<PubSubEvent<PlayerScoreUpdate>>().Subscribe(UpdateScore);            
        }

        public UserViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void UpdateScore(PlayerScoreUpdate obj)
        {
            if (obj.ButtonId != ButtonId) return;

            if (obj.IsScoreCorrection)
            {
                Score = obj.ScoreAmount;
            }
            else
            {
                Score += obj.ScoreAmount;
            }
        }
    }
}
