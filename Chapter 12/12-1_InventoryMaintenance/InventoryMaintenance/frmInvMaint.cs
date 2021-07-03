using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
	{
		public frmInvMaint()
		{
			InitializeComponent();
		}

        // Add a statement here that declares the list of items.
        private List<InvItem> invItems = null;

		private void frmInvMaint_Load(object sender, EventArgs e)
		{
            // Add a statement here that gets the list of items.
            invItems = InvItemDB.GetItems();
			FillItemListBox();
		}

		private void FillItemListBox()
		{
			lstItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            foreach(InvItem i in invItems)
            {
                lstItems.Items.Add(i.GetDisplayText());
            }
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            // Add code here that creates an instance of the New Item form
            // and then gets a new item from that form.
            frmNewItem newItemForm = new frmNewItem(); // creates an instance of the New Item form
            InvItem invItem = newItemForm.GetNewItem(); // gets a new item of from that form. Calls getNewItem() method from the frmNewItem class.
            if(invItem != null) // if the invItem properties that are sent between InvItem.cs and frmNewItem is not null then
            {
                invItems.Add(invItem); // Add this item to the list
                InvItemDB.SaveItems(invItems); // Saves the list(updates) to the text file database
                FillItemListBox(); // populates the text feild with the information of the item (ItemNum, Description, Price)
            }
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i = lstItems.SelectedIndex;
			if (i != -1)
			{
                // Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.
                InvItem invItem = invItems[i];
                string message = "Are you sure you want to delete " + invItem.Description + "?";
                DialogResult button = MessageBox.Show(message, "Delete Confirmation", MessageBoxButtons.YesNo);
                if(button == DialogResult.Yes)
                {
                    invItems.Remove(invItem);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}