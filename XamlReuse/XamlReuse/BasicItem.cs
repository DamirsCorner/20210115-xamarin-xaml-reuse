namespace XamlReuse
{
    public class BasicItem : IItem
    {
        public BasicItem(string title, string details)
        {
            Title = title;
            Details = details;
        }

        public string Title { get; }
        public string Details { get; }
    }
}
