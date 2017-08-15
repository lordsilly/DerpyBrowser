using System;

namespace DerpyBrowser
{
    [Serializable()]
    public class Address
    {
        protected string uri;
        public Address(string uri)
        {
            this.uri = uri;
        }

        public Address()
        {
        }

        public string getUri()
        {
            return uri;
        }
    }
}
