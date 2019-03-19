using Game1.Events;
using InputCapture;
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
        public bool IsInEditMode
        {
            get => _isInEditMode;
            set
            {
                kb.SuspendNotifications(value);
                _isInEditMode = value;
            }
        }

        public bool Selected { get; set; }

        private IKeyboardCapture kb;
        private bool _isInEditMode;

        public UserViewModel(IEventAggregator eventAggregator, IKeyboardCapture keyboard)
        {
            eventAggregator.GetEvent<PubSubEvent<PlayerScoreUpdate>>().Subscribe(UpdateScore);
            kb = keyboard;
            Selected = false;
            IsInEditMode = false;

            kb.KeyboardNotification += Kb_KeyboardNotification;
            kb.KeyboardReset += (s, e) => Selected = false;
        }

        private void Kb_KeyboardNotification(object sender, KeyboardNotificationEventArgs e)
        {
            if (LockoutKeyboardCapture.IntKeyLookup.TryGetValue(e.Key, out int value))
            {
                if (value == ButtonId)
                {
                    Selected = true;
                }
                else
                {
                    Selected = false;
                }
            }
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
