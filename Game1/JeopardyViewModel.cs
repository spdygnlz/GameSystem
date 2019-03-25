using Game1.ViewModels;
using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    [Export, PartCreationPolicy(CreationPolicy.Shared)]
    public class JeopardyViewModel: INotifyPropertyChanged
    {
        public DataTable table = new DataTable();
        private JeopardyModel model;
        private IKeyboardCapture kb = null;
        private GameState _state;

        public GameState State
        {
            get
            {
                return _state;
            }
            set
            {
                if (_state != value)
                {
                    _state = value;                    
                    eventAggregator.GetEvent<PubSubEvent<JeopardyViewModel>>().Publish(this);
                }
            }
        }
        private readonly IEventAggregator eventAggregator;

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<GameState> MyEnumTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(GameState)).Cast<GameState>();
            }
        }

        public string LastPressed { get; set; }

        public ObservableCollection<UserViewModel> Users { get; set; }

        public string FileName
        {
            set
            {
                model = JeopardyModelHelper.OpenModel(value);
            }
        }

        [ImportingConstructor]
        public JeopardyViewModel(IEventAggregator eventAggregator)
        {
            State = GameState.Jeopardy;
            this.eventAggregator = eventAggregator;
            eventAggregator.GetEvent<PubSubEvent<GameState>>().Subscribe(s => State = s);

            kb = ServiceLocator.Current.GetInstance<IKeyboardCapture>();
            kb.KeyboardNotification += Kb_KeyboardNotification;
        }

        private void Kb_KeyboardNotification(object sender, KeyboardNotificationEventArgs e)
        {
            this.LastPressed = e.Key.ToString();
        }

        public List<JeopardyCategory> Categories
        {
            get
            {
                switch (State)
                {
                    case GameState.Jeopardy:
                        return model.Categories;
                    case GameState.DoubleJeopardy:
                        return model.DoubleJeopardyCategories;
                    case GameState.FinalJeopardy:
                        return new List<JeopardyCategory>() { model.FinalJeopardy };
                }
                return new List<JeopardyCategory>();
            }
        }

        public void WriteModel(string filename)
        {
            JeopardyModelHelper.WriteModel(filename, model);
        }
    }

    public enum GameState
    {
        Jeopardy,
        DoubleJeopardy,
        FinalJeopardy
    }
}
