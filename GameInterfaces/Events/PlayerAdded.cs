using Prism.Events;

namespace GameInterfaces
{
    public class PlayerAdded : PubSubEvent<NewPlayerInfo>
    {
    }

    public class NewPlayerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
