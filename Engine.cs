using System.Collections.Generic;
using System.Xml.Linq;

namespace Search
{
    public class Engine
    {
        private bool defaultEngine;
        public bool DefaultEngine
        {
            get { return defaultEngine; }
            set { defaultEngine = value; }
        }

        private string shortcut;
        public string Shortcut
        {
            get { return shortcut; }
            set { shortcut = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string extUrl;
        public string ExtUrl
        {
            get { return extUrl; }
            set { extUrl = value; }
        }

        private string intUrl;
        public string IntUrl
        {
            get { return intUrl; }
            set { intUrl = value; }
        }

        private Dictionary<string, string> intParams;
        public Dictionary<string, string> IntParams
        {
            get { return intParams; }
            set { intParams = value; }
        }

        public List<XAttribute> getAttributes()
        {
            List<XAttribute> tmp = new List<XAttribute>();

            foreach (KeyValuePair<string, string> kvp in intParams)
            {
                tmp.Add(new XAttribute(kvp.Key, kvp.Value));
            }

            return tmp;
        }

        public Engine(string shortcut, string name, string extUrl, string intUrl, Dictionary<string, string> intParams, bool defaultEngine)
        {
            this.shortcut = shortcut;
            this.name = name;
            this.extUrl = extUrl;
            this.intUrl = intUrl;
            this.intParams = intParams;
            this.defaultEngine = defaultEngine;
        }
    }
}
