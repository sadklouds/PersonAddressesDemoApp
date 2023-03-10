using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonAddresses;
using PersonAddressLibrary;

namespace PersonAddresses
{
    public partial class AddressForm : Form
    {
        ISavedAddress _parent;
        public AddressForm(ISavedAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void saveAddressButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(streetAddressTextBox.Text))
            {
                MessageBox.Show("Please enter address before clicking save.", "blank Address field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                streetAddressTextBox.Select();
            }
            else if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                MessageBox.Show("Please enter a name before clicking save.", "blank City field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cityTextBox.Select();
            }
            else if (string.IsNullOrWhiteSpace(postcodeTextBox.Text))
            {
                MessageBox.Show("Please enter a email before clicking save.", "blank Postcode field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                postcodeTextBox.Select();
            }
            else
            {
                AddressModel address = new AddressModel()
                {
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    PostCode = postcodeTextBox.Text

                };

                _parent.SaveAddress(address);

                this.Close();
            }
        }
    }
}
