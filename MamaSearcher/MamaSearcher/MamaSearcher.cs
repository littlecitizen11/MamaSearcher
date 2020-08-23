using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace MamaSearcher
{
    public class MamaSearcher : IMamaSearcher
    {
        private Dictionary<string, Action<int, string>> dict = new Dictionary<string, Action<int, string>>();
        public void PerformSearch(string content)
        {
            foreach (var key in dict.Keys)
            {
                if(content.Contains(key))
                {
                    dict[key].Invoke(content.IndexOf(key), key);
                }
            }
        }


        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            dict.Add(pattern, actionToPerform);
        }
    }
}
