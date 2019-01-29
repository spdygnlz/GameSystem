using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaces
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PlayerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Initials
        {
            get
            {
                StringBuilder str = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    str.Append(FirstName.Substring(0, 1).ToUpperInvariant());
                }

                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    str.Append(LastName.Substring(0, 1).ToUpperInvariant());
                }

                return str.ToString();
            }
        }
        public int Id { get; set; }

        public int Score { get; private set; }

        public EventHandler<ScoreEventArgs> ScoreModified;
        public EventHandler<ScoreEventArgs> ScoreSet;

        [ImportingConstructor]
        public PlayerModel(IEventAggregator eventAggregator)
        {
            var scoreChangedToken = eventAggregator.GetEvent<ScoreChanged>().Subscribe(ChangeScore);
        }

        private void ChangeScore(ScoreInfo info)
        {
            if (info.PlayerId == Id)
            {
                Score += info.ScoreAmount;
                InvokeScoreModified(info.ScoreAmount);
            }
        }

        /// <summary>
        /// Use this event when the score changed by a certain amount.  e.g. when the user
        /// scored 25 points, or lost 50 points, etc.
        /// </summary>
        /// <param name="score">The amount to add/remove from the total score</param>
        public void InvokeScoreModified(int score)
        {
            ScoreModified?.Invoke(this, new ScoreEventArgs(score));
        }

        /// <summary>
        /// Use this event when the score changed to a set value. e.g. reset to 0 or 
        /// changed to 100, etc.
        /// </summary>
        /// <param name="score">The score that has been set.</param>
        public void InvokeScoreSet(int score)
        {
            ScoreSet?.Invoke(this, new ScoreEventArgs(score));
        }
    }


    public class ScoreEventArgs : EventArgs
    {
        public int Score { get; private set; }

        public ScoreEventArgs(int score)
        {
            Score = score;
        }

    }
}
