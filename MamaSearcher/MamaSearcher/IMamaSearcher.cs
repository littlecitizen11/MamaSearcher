using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public interface IMamaSearcher
    {
        public void Subscribe(string pattern, Action<int, string> actionToPerform);

        public void PerformSearch(string content);
    }

}
