namespace Game1.Events
{
    /// <summary>
    /// Simple PubSub event args to drive a card click event
    /// </summary>
    internal class ClickCard
    {
        public string CardName { get; set; }
    }
}
