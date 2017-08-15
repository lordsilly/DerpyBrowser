using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpyBrowser
{
    [Serializable()]
    public class FavouriteAddress : Address
    {
        private string name;

        public FavouriteAddress(string uri, string name) : base(uri)
        {
            this.name = name;
        }

        //ToString override to display correctly when added to FavouriteForm's listbox.
        public override string ToString()
        {
            return name + "     -     " + uri;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
