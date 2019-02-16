using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Agenda
{
    public partial class ContactCreation : Form
    {
        xmlDb dbAcess = new xmlDb();
        private static XmlDocument contactXml = null;
        public ContactCreation(XmlDocument receivedData)
        {
            contactXml = receivedData;
            InitializeComponent();
            create_btn.Enabled = false;
            phone_num_cmbbox.Items.Add("(Residencial)");
            phone_num_cmbbox.Items.Add("(Celular)");
            email_cmbbox.Items.Add("(Pessoal)");
            email_cmbbox.Items.Add("(Trabalho)");
        }

        private void create_btn_Click_1(object sender, EventArgs e)
        {
            XmlElement newContact = contactXml.CreateElement(string.Empty, name_txtbx.Text, string.Empty);
            if (phone_txtbx.Text != null && phone_txtbx.Text != "")
            {
                newContact.AppendChild(contactXml.CreateElement("Phone")).InnerText = phoneNumberParcer();
            }
            else
            {
                newContact.AppendChild(contactXml.CreateElement("Phone")).InnerText = "--";
            }
            if (email_txtbx.Text != null && email_txtbx.Text != "")
            {
                newContact.AppendChild(contactXml.CreateElement("Email")).InnerText = email_txtbx.Text + " " + email_cmbbox.Text;
            }
            else
            {
                newContact.AppendChild(contactXml.CreateElement("Email")).InnerText = "--";
            }

            if ((double.TryParse(phone_txtbx.Text, out double a) && phone_txtbx.Text.Length > 9 && phone_txtbx.Text.Length < 12) || phone_txtbx.Text.Trim() == "" )
            {
                if (!sameNameVerifier())
                {
                    success_lbl.Text = "Contato " + name_txtbx.Text + " criado.";
                    dbAcess.xmlBuilder(newContact);
                    name_txtbx.Text = "";
                    phone_txtbx.Text = "";
                    email_txtbx.Text = "";
                }
                else
                {
                    success_lbl.Text = "Contato já existente.";
                }
            }
            else
            {
                phone_failed_lbl.Text = "Número inválido";
            }
        }

        private void name_txtbx_TextChanged(object sender, EventArgs e)
        {
            create_btn.Enabled = false;

            if(name_txtbx.Text != null && name_txtbx.Text.Trim() != "")
            {
                if(!int.TryParse(name_txtbx.Text, out int a))
                {
                    create_btn.Enabled = true;
                }
            }
        }

        private void phone_txtbx_TextChanged(object sender, EventArgs e)
        {
            phone_failed_lbl.Text = "";
        }

        private string phoneNumberParcer()
        {
            char[] arrayConversor = phone_txtbx.Text.ToCharArray();
            string parcedNumber = "(";
            foreach(char number in arrayConversor)
            {
                parcedNumber += number;

                if(parcedNumber.Length == 3)
                {
                    parcedNumber += ") ";
                }

                if(arrayConversor.Length == 10 && parcedNumber.Length == 9)
                {
                    parcedNumber += " - ";
                }
                if (arrayConversor.Length == 11 && parcedNumber.Length == 10)
                {
                    parcedNumber += " - ";
                }
            }

            parcedNumber += phone_num_cmbbox.Text;

            return parcedNumber;
        }

        private bool sameNameVerifier()
        {
            foreach (XmlElement element in contactXml.SelectNodes("//body"))
            {
                if (element.Name.ToUpper().Equals(name_txtbx.Text.ToUpper()))
                {
                    return true;
                }
            }

            return false;                
        }
    }
}
