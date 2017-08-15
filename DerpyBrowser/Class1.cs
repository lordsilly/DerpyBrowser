using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpyBrowser
{

    class Address
    {
        private String uri;
        public Address(String uri)
        {
            this.uri = uri;
        }

        public String getUri()
        {
            return uri;
        }
    }
}
