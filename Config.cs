using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search
{
    class Config
    {
        public Config()
        {
            globalHotkeyModifiers = new List<int>();
        }

        /* true == open intern: CTRL + Enter */
        private bool openInternModifier;
        public bool OpenInternModifier
        {
            get { return openInternModifier; }
            set { openInternModifier = value; }
        }

        private List<int> globalHotkeyModifiers;
        public List<int> GlobalHotkeyModifiers
        {
            get { return globalHotkeyModifiers; }
            set { globalHotkeyModifiers = value; }
        }

        private int globalHotkeyKey;
        public int GlobalHotkeyKey
        {
            get { return globalHotkeyKey; }
            set { globalHotkeyKey = value; }
        }

        public void setGlobalHotkeyModifers(List<int> newList)
        {
            globalHotkeyModifiers.Clear();
            globalHotkeyModifiers = newList;
        }

        public int getGlobalHotkeyModifierValue()
        {
            int tmp = 0;
            foreach (int i in globalHotkeyModifiers)
                tmp += i;

            return tmp;
        }

        public string getGlobalHotkeyModifierString()
        {
            string tmp = "";
            foreach (int i in globalHotkeyModifiers)
            {
                switch (i)
                {
                    case 0:
                        tmp += "No Modifier" + " + ";
                        break;

                    case 1:
                        tmp += "ALT" + " + ";
                        break;

                    case 2:
                        tmp += "CTRL" + " + ";
                        break;

                    case 4:
                        tmp += "SHIFT" + " + ";
                        break;

                    case 8:
                        tmp += "WIN" + " + ";
                        break;
                }
            }

            return tmp.Substring(0, tmp.Length - 3);
        }
    }
}
