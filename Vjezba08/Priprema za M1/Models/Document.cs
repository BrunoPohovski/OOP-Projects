namespace Priprema_za_M1.Models
{
    public class Document : ISignable
    {
        public Document(string text, string title)
        {
            Text = text;
            Title = title;
        }

        private string Text { get; set; }
        private string Title { get; set; }
        
        public bool Approved { get; private set; }

        
        public void Sign() => Approved = true;
        public override string ToString()
        => $"Title: {Title}, Text: {Text}, Approved: {(Approved ? "Yes" : "No")}";
    }
}