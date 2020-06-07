using System;
using System.Configuration;
using System.Xml;

namespace EmployeeManagementSystem
{
    public class ChangeLanguage
    {
        public void UpdateConfig(string key, string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {

                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value.Equals(key))
                        {
                            if (xNode.Attributes[0].Value.Equals(key))
                            {
                                xNode.Attributes[1].Value = value;
                            }
                        }
                    }
                }
                ConfigurationManager.RefreshSection("appSettings");
                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }
        }

        public static string ReadConfigValue(string key)
        {
            string _value;
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            _value =  ConfigurationManager.AppSettings[key];
            
            return _value;

        }
    }
}



