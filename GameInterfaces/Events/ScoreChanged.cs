using Prism.Events;

namespace GameInterfaces
{
    public class ScoreChanged : PubSubEvent<ScoreInfo> { }

    public class ScoreInfo
    {
        public int PlayerId { get; set; }
        public int ScoreAmount { get; set; }
    }
}
