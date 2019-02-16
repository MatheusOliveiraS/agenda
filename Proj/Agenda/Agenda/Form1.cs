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
    public partial class Form1 : Form
    {
        xmlDb dbAcess = new xmlDb();
        XmlDocument data = null;
        string lastContactSelected = "";

        public Form1()
        {
            data = dbAcess.initialization();
            InitializeComponent();
            indexBuild();
            contactLoader();
            delete_lnklbl.Visible = false;
        }

        private void contactLoader()
        {
            foreach(XmlElement element in data.SelectNodes("//body"))
            {
                string phone = "";
                string email = "";
                foreach( XmlElement contacts in element)
                {
                    XmlNodeList children =  contacts.ChildNodes;
                    foreach (XmlNode node in children)
                    {
                        if (node.Name == "Phone")
                        {
                            phone = node.InnerText;
                        }
                        if (node.Name == "Email")
                        {
                            email = node.InnerText;
                        }
                    }
                     this.contacts_dataGrid.Rows.Add(contacts.Name, phone, email);
                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ContactCreation(data).Show();

            contacts_dataGrid.Refresh();
        }

        private void indexBuild()
        {
            int asciiDec = 65;
            index_cmbbox.Items.Add("Todos");

            while(asciiDec < 91)
            {
                char item = (char)asciiDec;
                index_cmbbox.Items.Add(item);
                asciiDec++;
            }
        }

        private void index_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            agendaSort(index_cmbbox.Text.ToString());
        }

        private void agendaSort(string value)
        {
            contacts_dataGrid.Rows.Clear();

            if(value.ToUpper().Equals("TODOS"))
            {
                contactLoader();
            }
            else
            {
                foreach (XmlElement element in data.SelectNodes("//body"))
                {
                    string phone = "";
                    string email = "";
                    foreach (XmlElement contacts in element)
                    {
                        if (contacts.Name[0].ToString().ToUpper().Equals(value))
                        {
                            XmlNodeList children = contacts.ChildNodes;
                            foreach (XmlNode node in children)
                            {
                                if (node.Name == "Phone")
                                {
                                    phone = node.InnerText;
                                }
                                if (node.Name == "Email")
                                {
                                    email = node.InnerText;
                                }
                            }
                            this.contacts_dataGrid.Rows.Add(contacts.Name, phone, email);
                        }
                    }
                }
            }

            contacts_dataGrid.Refresh();
        }

        private void contacts_dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedContact = contacts_dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string phone = "";
            string email = "";
            foreach (XmlElement element in data.SelectNodes("//body"))
            {
                foreach (XmlElement contacts in element)
                {
                    if (contacts.Name.Equals(selectedContact))
                    {
                        XmlNodeList children = contacts.ChildNodes;
                        foreach (XmlNode node in children)
                        {
                            if (node.Name == "Phone")
                            {
                                phone = node.InnerText;
                            }
                            if (node.Name == "Email")
                            {
                                email = node.InnerText;
                            }
                        }
                        MessageBox.Show("Nome do contato:" + contacts.Name + "\n" +
                                        "Número de telefone:" + phone + "\n" +
                                        "Endereço de E-mail:" + email, "Informações do contato" );
                    }
                }
            }
        }

        private void contacts_dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lastContactSelected = contacts_dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            delete_lnklbl.Visible = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            delete_lnklbl.Visible = false;
        }

        private void delete_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja deletar o contato?", "Atenção!", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                dbAcess.contactEraser(lastContactSelected);
                contacts_dataGrid.Refresh();
            }            
        }
    }
}
