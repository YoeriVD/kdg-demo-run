using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KdgApplication.Core.Texts;

namespace KdgApplication.Core.Sentiments
{
    public class Sentiment 
    {
        public Sentiment()
        {
            Id = Guid.NewGuid();
            //Texts = new HashSet<TextAnalysis>();
        }

        //public virtual ICollection<TextAnalysis> Texts { get; set; }

        public string EmotionName { get; set; }
        public EmotionKind EmotionKind { get; set; }
        public Guid Id { get; set; }
    }
}
