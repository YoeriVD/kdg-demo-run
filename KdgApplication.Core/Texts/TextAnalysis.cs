using System;

namespace KdgApplication.Core.Texts
{
    public class TextAnalysis
    {
        public TextAnalysis()
        {
            Id = Guid.NewGuid();
            //Sentiments = new HashSet<Sentiment>();
        }

        public string Title { get; set; }
        public string TextContent { get; set; }
        //public virtual ICollection<Sentiment> Sentiments { get; set; }
        public Guid Id { get; set; }
    }
}
