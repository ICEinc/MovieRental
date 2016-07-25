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
    public partial class RentalInfo : Form
    {
        public RentalInfo()
        {
            InitializeComponent();
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

        private void rentalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new RentalInfo();
            fr.Show();
            this.Hide();
        }
        public void enable()
        {
            txtRentalType.Enabled = true;
            txtNoOfDays.Enabled = true;
            txtRentalFee.Enabled = true;
            txtPenaltyFee.Enabled = true;
        }
        public void disable()
        {
            txtRentalType.Enabled = false;
            txtNoOfDays.Enabled = false;
            txtRentalFee.Enabled = false;
            txtPenaltyFee.Enabled = false;
        }
        public void Clear()
        {
            txtRentalType.Text = "" ;
            txtNoOfDays.Text = "" ;
            txtRentalFee.Text = "" ;
            txtPenaltyFee.Text = "" ;
            txtMovieID.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RentalInfo_Load(object sender, EventArgs e)
        {

        }

        private void cboRentalType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Transaction();
            fr.Show();
            this.Hide();
        }
    }
}
