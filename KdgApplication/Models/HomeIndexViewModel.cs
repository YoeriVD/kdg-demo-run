using System.Collections.Generic;
using KdgApplication.Core.Texts;

namespace KdgApplication.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<TextAnalysis> TextCards { get; set; }
    }
}