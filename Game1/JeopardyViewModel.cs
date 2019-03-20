using Game1.ViewModels;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    [Export, PartCreationPolicy(CreationPolicy.Shared)]
    public class JeopardyViewModel
    {
        public DataTable table = new DataTable();
        private JeopardyModel model;
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

        public IEnumerable<GameState> MyEnumTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(GameState)).Cast<GameState>();
            }
        }

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
