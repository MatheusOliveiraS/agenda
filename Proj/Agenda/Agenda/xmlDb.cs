using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace Agenda
{
    class xmlDb
    {
        private string path = Environment.CurrentDirectory + "\\xmlDb.xml";
        private static XmlDocument data = new XmlDocument();
        private XmlDeclaration XmlDeclaration = data.CreateXmlDeclaration("1.0", "UTF-8", null);
        private XmlElement bodyElement = data.CreateElement(string.Empty, "body", string.Empty);

        public XmlDocument initialization()
        {
            if (!File.Exists(path))
            {
                data.AppendChild(bodyElement);

                data.Save(path);
            }
            else
            {
                data.Load(path);
            }

            return data;
        }

        public void xmlBuilder(XmlElement newContact)
        {
            try
            {
                foreach(XmlElement element in data.SelectNodes("//body"))
                {
                    element.AppendChild(newContact);
                }
                data.Save(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception!");
            }
        }

        public void contactEraser(string contact)
        {
            try
            {
                foreach (XmlElement element in data.SelectNodes("//body"))
                {
                    foreach (XmlElement contacts in element)
                    {
                        if (contacts.Name.Equals(contact))
                        {
                            element.RemoveChild(data.SelectSingleNode("/body/" + contact));

                            data.Save(path);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception!");
            }
        }
    }
}
