using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace Search
{
    static class XMLUtil
    {
        private static Form1 form;

        internal static void init(Form1 form1)
        {
            form = form1;
        }

        internal static void readConfig()
        {
            //form.globalHotkey = new GlobalHotkey(Constants.CTRL + Constants.WIN, System.Windows.Forms.Keys.None, form);

            form.config.GlobalHotkeyModifiers.Clear();

            string path = "config.xml";
            XDocument dom = XDocument.Load(File.OpenRead(path));

            XElement ghElem = dom.Descendants("GlobalHotkey").FirstOrDefault();

            foreach (XElement modifierElem in ghElem.Element("Modifiers").Elements("Modifier"))
            {
                int mod;
                if (Int32.TryParse(modifierElem.Value, out mod))
                    form.config.GlobalHotkeyModifiers.Add(mod);
            }
            
            int ghKey;
            if (Int32.TryParse(ghElem.Element("Key").Value, out ghKey))
                form.config.GlobalHotkeyKey = ghKey;

            XElement shElem = dom.Descendants("SearchHotkey").FirstOrDefault();

            if (shElem.Element("Intern").Attribute("modifier").Value.ToLower().Equals("true"))
                form.config.OpenInternModifier = true;
            else
                form.config.OpenInternModifier = false;
        }

        internal static void writeConfig()
        {
            XElement cfg =
                new XElement("Config",
                    new XElement("GlobalHotkey",
                        new XElement("Modifiers",
                            from sel in form.config.GlobalHotkeyModifiers
                            select
                                new XElement("Modifier", sel.ToString())
                                ),
                        new XElement("Key", form.config.GlobalHotkeyKey.ToString())
                    ),
                    new XElement("SearchHotkey",
                        new XElement("Intern", new XAttribute("modifier", form.config.OpenInternModifier.ToString()))
                    )
                );

            string outpath = "config.xml";
            try
            {
                using (var outFile = File.CreateText(outpath))
                {
                    outFile.Write(cfg.ToString());
                }
            }
            catch (Exception e) { }
        }

        internal static void readEngines()
        {
            string path = "engines.xml";
            XDocument dom = XDocument.Load(File.OpenRead(path));

            XElement enginesElem = dom.Descendants("Engines").FirstOrDefault();

            foreach (XElement engineElem in enginesElem.Elements("Engine"))
            {
                string shortcut = engineElem.Element("Shortcut").Value;
                string name = engineElem.Element("Name").Value;

                string extUrl;
                string intUrl;
                try
                {
                    extUrl = engineElem.Element("extURL").Value;
                    intUrl = engineElem.Element("intURL").Value;
                }
                catch (NullReferenceException)
                {
                    try
                    {
                        extUrl = engineElem.Element("URL").Value;
                        intUrl = engineElem.Element("URL").Value;
                    }
                    catch (NullReferenceException)
                    {
                        extUrl = null;
                        intUrl = null;
                        continue;
                    }
                }

                Dictionary<string, string> intParams = new Dictionary<string, string>();
                if (engineElem.Element("intParams") != null)
                {
                    intParams = engineElem.Element("intParams").Attributes().ToDictionary(attr => attr.Name.LocalName, attr => attr.Value);
                }

                if (engineElem.Attribute("default") != null && engineElem.Attribute("default").Value == "true")
                {
                    Engine tmp = new Engine(shortcut, name, extUrl, intUrl, intParams, true);
                    form.defaultEngine = tmp;
                    form.ENGINES.Add(shortcut, tmp);
                }
                else
                {
                    form.ENGINES.Add(shortcut, new Engine(shortcut, name, extUrl, intUrl, intParams, false));
                }
            }

            form.selectedEngine = form.defaultEngine;
        }

        internal static void writeEngines()
        {
            XElement engines =
                new XElement("Engines",
                    from sel in form.ENGINES.Values
                    select
                        new XElement("Engine",
                            (sel.DefaultEngine == true) ? new XAttribute("default", "true") : null,
                            new XElement("Shortcut", sel.Shortcut),
                            new XElement("Name", sel.Name),
                            new XElement("extURL", sel.ExtUrl),
                            new XElement("intURL", sel.IntUrl),
                            new XElement("intParams", sel.getAttributes())
                        )
                );

            string outpath = "engines.xml";
            try
            {
                using (var outFile = File.CreateText(outpath))
                {
                    outFile.Write(engines.ToString());
                }
            }
            catch (Exception e) { }
            finally
            {
                // Write to another file, when engines.xml is used by any process
                outpath = "engines2.xml";
                using (var outFile = File.CreateText(outpath))
                {
                    outFile.Write(engines.ToString());
                }
            }
        }
    }
}
