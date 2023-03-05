using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Simple_TextEditor;

namespace AddressBookProgram
{
    public partial class AddressBook : Form
    {
        // list to store all the contacts
        List<Contact> Usercontacts = new List<Contact>();


        public AddressBook()
        {
            InitializeComponent();
        }
        // add a new contact to the list
        private void BTNEAdd_Click(object sender, EventArgs e)
        {
            // new object to store contact data entered
            Contact newUserContact = new Contact();
            newUserContact.Title = txtTitle.Text;
            newUserContact.FName = txtFirstName.Text;
            newUserContact.SName = txtSurname.Text;
            newUserContact.Address = txtAddress.Text;
            newUserContact.Telno = NUDTelNo.Value;


            // IF statement to check if the user entered at least a first name, otherwise program displays error.
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("In order to add a contact there needs to be a firstname entered",
                    "Could not add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // add the contact to list - showing Title, firstname, surname in list.]
                Usercontacts.Add(newUserContact);
                // display first and surname in listbox
                LBContactList.Items.Add($"{newUserContact.FName} {newUserContact.SName}");
                // bring up sub routine to clear the details ready for next entry
                clearContactDetails();
                MessageBox.Show("Contact added to the list", "Add contact",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // remove the label that checks if there are no contacts in the listbox
                this.LBLContactsPresentCheck.Visible = false;
            }

        }

        // sub routine method for clearing the details boxes
        public void clearContactDetails()
        {
            this.txtTitle.Clear();
            this.txtFirstName.Clear();
            this.txtSurname.Clear();
            this.txtAddress.Clear();
        }

        private void LBContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // gather index of selected value
            int index = LBContactList.SelectedIndex;

            // check there are contacts within the index to choose from
            if (index == -1) return;
            // gather contact object
            Contact contactChosen = Usercontacts[index];

            // When the user chooses a contact in the list, all the contacts should be displayed. 
            txtTitle.Text = contactChosen.Title;
            txtFirstName.Text = contactChosen.FName;
            txtSurname.Text = contactChosen.SName;
            txtAddress.Text = contactChosen.Address;
            NUDTelNo.Value = contactChosen.Telno;

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // gather index of selected value
            int index = LBContactList.SelectedIndex;
            // check there are contacts within the index to choose from
            if (index == -1) return;

            Contact contactChosen = Usercontacts[index];

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("In order to save changes to a contact there needs to be a firstname entered",
                    "Could not add contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Changes saved successfully", "Save changes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                contactChosen.Title = txtTitle.Text;
                contactChosen.FName = txtFirstName.Text;
                contactChosen.SName = txtSurname.Text;
                contactChosen.Address = txtAddress.Text;
                contactChosen.Telno = NUDTelNo.Value;
                // update listbox with new contact names
                LBContactList.Items[LBContactList.SelectedIndex] = $"{contactChosen.FName} {contactChosen.SName}";
            }
        }
            // ================= UI OPTION CUSTOMIZATION ===================== //

        // If the checkbox is checked (Ticked), the program will be pinned to the screen, so if the user clicks off the program, it still displays
        private void CHKBXPinToTop_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKBXPinToTop.Checked)
            {
                this.TopMost = !this.TopMost;
            }
        }

        // If the checkbox is checked, dark theme will turn the program UI darkGray
        private void CHKBXDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKBXDarkTheme.Checked)
            {
                this.BackColor = Color.DarkGray;
                this.TabPageInformation.BackColor = Color.DarkGray;
                this.TabPageOptions.BackColor = Color.DarkGray;
            }
            else
            {
                this.BackColor = Color.White;
                this.TabPageInformation.BackColor = Color.White;
                this.TabPageOptions.BackColor = Color.White;
            }
         }

        private void BTNClearAllContacts_Click(object sender, EventArgs e)
        {
            DialogResult ClearAllContactDataWarning = MessageBox.Show("You are about to delete all the contacts stored within the list, " +
                "Are you sure you want to proceed with removal?", "Clear data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ClearAllContactDataWarning == DialogResult.Yes)
            {
                LBContactList.Items.Clear();
                MessageBox.Show("AddressBook data reset", "Data removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LBLContactsPresentCheck.Visible = true;
            }
        }

        private void BTNRemove_Click(object sender, EventArgs e)
        {
            if (LBContactList.SelectedItem == null)
            {
                MessageBox.Show("No contact selected, please click on a contact within the listbox",
                    "Remove contact error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // variable that will display an message asking if the user wants to remove a contact
                DialogResult RemoveContactPrompt = MessageBox.Show("Are you sure you want to remove this contact?",
                    "Remove contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user chooses yes, the contact will be removed from the list and the detail boxes will be cleared
                if (RemoveContactPrompt == DialogResult.Yes)
                {
                    LBContactList.Items.Remove(LBContactList.SelectedItem);
                    clearContactDetails();
                }
            }
        }
    }
  }




  
 


