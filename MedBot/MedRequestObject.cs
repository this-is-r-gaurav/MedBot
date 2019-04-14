using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedBot
{
    class MedRequestObject
    {
        public string text { get; set; }
        public bool withContext { get; set; }
        public string withMatchLogic { get; set; }
        public bool withText { get; set; }
        public MedRequestObject(string text, bool withContext=true, string withMatchLogic= "ignore-length", bool withText = true)
        {
            this.text = text;
            this.withContext = withContext;
            this.withMatchLogic = withMatchLogic;
            this.withText = withText;
        }
    }
}
