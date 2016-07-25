using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieRentalLogin
{
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {

        }
        public void DisableButton()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "add")
            {

                txtLastName.Select();
                DisableButton();
                btnAdd.Enabled = true;
                btnCancel.Enabled = true;
                enable();
                btnAdd.Text = "save";
            }
            else if (btnAdd.Text == "save")
            {
                disable();
                Clear();
                MessageBox.Show("Customer Information Saved!");
                btnAdd.Text = "add";
                DisableButton();
                btnAdd.Enabled = true;
            }
        }
        public void enable()
        {
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;
            txtLastName.Enabled = true;
            txtMI.Enabled = true;
            txtFirstName.Enabled = true;
            cboIsActive.Enabled = true;
        }
        public void disable()
        {
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            txtEmail.Enabled = false;
            txtLastName.Enabled = false;
            txtMI.Enabled = false;
            txtFirstName.Enabled = false;
            cboIsActive.Enabled = false;
        }
        public void Clear()
        {
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtLastName.Text = "";
            txtMI.Text = "";
            txtFirstName.Text = "";
            txtCustomerID.Text = "";
            cboIsActive.Text = "";
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Movies();
            fr.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new CustomerInfo();
            fr.Show();
            this.Hide();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Transaction();
            fr.Show();
            this.Hide();
        }

        private void rentalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new RentalInfo();
            fr.Show();
            this.Hide();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movierentalDataSet);

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.MaxLength = 20;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.MaxLength = 20;
        }

        private void txtMI_TextChanged(object sender, EventArgs e)
        {
            txtMI.MaxLength = 1;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.MaxLength = 50;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            txtContact.MaxLength = 11;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 50;
        }

        private void cboIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("are you sure you want to cancel?", "Cancel Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Clear();
                disable();
                if (btnAdd.Enabled == true)
                {
                    MessageBox.Show("Movie Cancelled!");
                    DisableButton();
                    btnAdd.Text = "add";
                    btnAdd.Enabled = true;
                }
                else if (btnEdit.Enabled == true)
                {
                    MessageBox.Show("Update Cancelled!");
                    DisableButton();
                    btnAdd.Text = "add";
                    btnAdd.Enabled = true;
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
