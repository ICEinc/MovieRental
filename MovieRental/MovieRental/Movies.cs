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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtTittle.MaxLength = 30;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            txtLanguage.MaxLength = 10;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtDescription.MaxLength = 100;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            txtCast.MaxLength = 50;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (btnAdd.Text == "edit")
            {
                DisableButton();
                btnEdit.Enabled = true;
                btnCancel.Enabled = true;
                enable();
                btnAdd.Text = "update";
            }
            else if (btnAdd.Text == "update")
            {
                disable();
                Clear();
                MessageBox.Show("Movie Successfully Updated!");
                btnAdd.Text = "edit";
                DisableButton();
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (btnAdd.Text == "add")
            {

                txtTittle.Select();
                DisableButton();
                btnAdd.Enabled = true;
                btnCancel.Enabled = true;
                enable();
                btnAdd.Text = "save";
            }
            else if(btnAdd.Text == "save")
            {
                disable();
                Clear();
                MessageBox.Show("Movie Successfully Saved!");
                btnAdd.Text = "add";
                DisableButton();
                btnAdd.Enabled = true;
            }

        }
        public void Clear() 
        {
            txtCast.Text = "";
            txtDescription.Text = "";
            txtID.Text = "";
            txtLanguage.Text = "";
            txtTittle.Text = "";
            cboGenre.Text = "";
            Date.Text = "";
        }
        public void enable() 
        {
            txtTittle.Enabled = true;
            txtCast.Enabled = true;
            txtDescription.Enabled = true;
            txtLanguage.Enabled = true;
            cboGenre.Enabled = true;
            Date.Enabled = true;
            btnUpload.Enabled = true;
        }
        public void disable()
        {
            txtTittle.Enabled = false;
            txtCast.Enabled = false;
            txtDescription.Enabled = false;
            txtLanguage.Enabled = false;
            cboGenre.Enabled = false;
            Date.Enabled = false;
            btnUpload.Enabled = false;
        }
        public void DisableButton() 
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            DialogResult dres1 = fd1.ShowDialog();
            fd1.Filter = "image files|*.jpg;*.png;.*gif;*.icon;.*;";
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fr = new CustomerInfo();
            fr.Show();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fr = new Movies();
            fr.Show();
        }

        private void rentalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new RentalInfo();
            fr.Show();
            this.Hide();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Transaction();
            fr.Show();
            this.Hide();
        }
    }
}
