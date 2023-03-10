using PersonAddressLibrary;
using System.ComponentModel;

namespace PersonAddresses
{
    public partial class PersonEntry : Form, ISavedAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        List<PersonModel> persons = new List<PersonModel>();

        public PersonEntry()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter a name before trying clicking create.", "blank Firstname field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Select();
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter a name before trying clicking create.", "blank Last name field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Select();
            }
            else if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please enter email before trying clicking create.", "blank email field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Select();
            }
            else
            {
                persons.Add(new PersonModel ( firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, addresses.ToList()));
            }
        }
        private void WireUpLists()
        {
            addressListBox.DataSource = addresses;
            addressListBox.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }
        private void addressButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(this);
            addressForm.Show();

        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }
    }
}