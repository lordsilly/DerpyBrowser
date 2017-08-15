using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpyBrowser
{
    [Serializable()]
    public class HistoryAddress : Address
    {
        //variables
        private DateTime visited;                       //date/time page was last visited

        //constructor
        public HistoryAddress(string uri) : base(uri)
        {
            this.visited = DateTime.UtcNow;
        }

        //methods

        //get date/time last visited
        public DateTime getVisited()
        {
            return visited;
        }
    }
}
