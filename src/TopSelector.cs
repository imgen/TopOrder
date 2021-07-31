using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopOrder
{
    public class TopSelector
    {
        public string SelectKthElement(string[] elements, int k = 0, StringComparer comparer = null)
        {
            k = k <= 0 ? 10 : k;
            comparer ??= StringComparer.InvariantCultureIgnoreCase;

        }
    }
}
