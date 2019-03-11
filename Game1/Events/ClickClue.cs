namespace Game1.Events
{
    /// <summary>
    /// Simple PubSub event args to drive a clue window click event
    /// </summary>
    internal class ClickClue
    {
        public string ClueName { get; set; }
    }
}
