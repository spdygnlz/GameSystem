namespace Game1.Events
{
    public class PlayerScoreUpdate
    {
        public int ButtonId { get; set; }
        public int ScoreAmount { get; set; }
        public bool IsScoreCorrection { get; set; }

        public PlayerScoreUpdate()
        {
            IsScoreCorrection = false;
        }
    }
}
