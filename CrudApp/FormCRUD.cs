namespace CrudApp
{
    public partial class CRUDForm : Form
    {
        private Color ON_FOCUS_COLOR = Color.Aqua;
        private Color LOST_FOCUS_COLOR = Color.White;

        public CRUDForm()
        {
            InitializeComponent();
        }

        private void ClearCreateForm()
        {
            TextName.Text = string.Empty;
            DOB.Value = DateTime.Now;
            Licensed.Checked = false;
            TextContact.Text = string.Empty;
        }

        private void ShowErrorMessage(String message, String title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfoMessage(String message, String title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (TextName.Text.Trim() == "")
            {
                errorProvider1.SetError(TextName, "Name is a required data.");
                TextName.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(TextName, "");
            }
            if (TextContact.Text.Trim() == "")
            {
                errorProvider1.SetError(TextContact, "Please enter a valid contact number.");
                TextContact.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(TextContact, "");
            }
            CrudApp.Customer customerObject = new CrudApp.Customer();
            customerObject.CustomerName = TextName.Text.Trim();
            customerObject.DOB = DOB.Value;
            customerObject.Licensed = Licensed.Checked;
            customerObject.ContactNumber = TextContact.Text.Trim();

            CrudApp.Database myDatabase = new CrudApp.Database();
            if (myDatabase.HasConnection)
            {
                bool created = myDatabase.Create(customerObject);
                if (created)
                {
                    ShowInfoMessage("Data Created successfully.", "CRUD App - Create");
                    ListDetails.Items.Clear();
                    ClearCreateForm();
                    TextName.Focus();
                }
                else
                {
                    ShowErrorMessage("Could not create data.", "CRUD App - Create");
                    TextName.Focus();
                }
            }
        }

        private void CRUDForm_Load(object sender, EventArgs e)
        {

        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = ON_FOCUS_COLOR;
        }

        private void Control_LostFocus(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = LOST_FOCUS_COLOR;
            errorProvider1.SetError(control, "");
        }


        private void ButtonRead_Click(object sender, EventArgs e)
        {
            CrudApp.Database myDatabase = new Database();
            if (myDatabase.HasConnection)
            {
                CrudApp.Customer[] customers;
                ListDetails.Items.Clear();
                customers = myDatabase.Read();
                if (customers.Length > 0)
                {
                    for (int i = 0; i < customers.Length; i++)
                    {
                        ListViewItem lst = ListDetails.Items.Add(customers[i].CustomerID.ToString());
                        lst.SubItems.Add(customers[i].CustomerName);
                        lst.SubItems.Add(customers[i].DOB.ToString("dd-MMM-yyyy"));
                        lst.SubItems.Add(customers[i].Licensed.ToString());
                        lst.SubItems.Add(customers[i].ContactNumber);
                    }
                }
                else
                {
                    ShowInfoMessage("No records to read", "CRUD App - Read Button");
                }
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void ButtonR_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ButtonU_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void ClearUpdateForm()
        {
            TextCustID.Text = string.Empty;
            TextCustName.Text = string.Empty;
            DOB2.Value = DateTime.Now;
            Licensed2.Checked = false;
            TextContact2.Text = string.Empty;
        }

        private void ClearDeleteForm()
        {
            TextCustID2.Text = string.Empty;
            TextCustName2.Text = string.Empty;
            TextDOB.Text = string.Empty;
            TextLicensed.Text = string.Empty;
            TextContact3.Text = string.Empty;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int CustID = 0;
            try
            {
                CustID = int.Parse(TextID.Text);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Parsing Error");
            }

            if (CustID > 0)
            {
                errorProvider1.SetError(TextID, "");
                CrudApp.Database database = new Database();
                if (database.HasConnection)
                {
                    Customer customer = database.GetCustomerByID(CustID);
                    if (customer.CustomerID > 0)
                    {
                        TextCustID.Text = customer.CustomerID.ToString();
                        TextCustName.Text = customer.CustomerName;
                        DOB2.Value = customer.DOB;
                        Licensed2.Checked = customer.Licensed;
                        TextContact2.Text = customer.ContactNumber;
                        TextCustName.Focus();
                    }
                    else
                    {
                        ClearUpdateForm();
                        ShowErrorMessage("Record not found", "Search Result");
                        TextID.Focus();
                    }
                }
            }
            else
            {
                ClearUpdateForm();
                errorProvider1.SetError(TextID, "Not a valid ID.");
                TextID.Focus();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (TextCustName.Text.Trim() == "")
            {
                errorProvider1.SetError(TextCustName, "Name is a required data.");
                TextCustName.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(TextCustName, "");
            }
            if (TextContact2.Text.Trim() == "")
            {
                errorProvider1.SetError(TextContact2, "Please enter a valid contact number.");
                TextContact2.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(TextContact2, "");
            }
            if (TextCustID.Text.Length > 0)
            {
                errorProvider1.SetError(TextID, "");
                CrudApp.Database database = new Database();
                if (database.HasConnection)
                {
                    CrudApp.Customer customer = new Customer();
                    customer.CustomerID = int.Parse(TextCustID.Text);
                    customer.CustomerName = TextCustName.Text.Trim();
                    customer.DOB = DOB2.Value;
                    customer.Licensed = Licensed2.Checked;
                    customer.ContactNumber = TextContact2.Text.Trim();
                    bool result = database.Update(customer);
                    if (result)
                    {
                        ShowInfoMessage("Data updated successfully.", "CRUD App - Update");
                        ListDetails.Items.Clear();
                        ClearUpdateForm();
                        TextID.Text = string.Empty;
                        TextID.Focus();
                    }
                    else
                    {
                        ShowErrorMessage("Could not Update data.", "CRUD App - Update");
                        TextCustName.Focus();
                    }
                }
            }
            else
            {
                ClearUpdateForm();
                errorProvider1.SetError(TextID, "Not a valid ID.");
                TextID.Focus();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (TextCustID2.Text.Length > 0)
            {
                errorProvider1.SetError(TextID2, "");
                CrudApp.Database database = new Database();
                if (database.HasConnection)
                {
                    CrudApp.Customer customer = new Customer();
                    customer.CustomerID = int.Parse(TextCustID2.Text);
                    bool result = database.Delete(customer);
                    if (result)
                    {
                        ShowInfoMessage("Data deleted successfully.", "CRUD App - Delete");
                        ListDetails.Items.Clear();
                        ClearDeleteForm();
                        TextID2.Text = string.Empty;
                        TextID2.Focus();
                    }
                    else
                    {
                        ShowErrorMessage("Could not delete data.", "CRUD App - Delete");
                        TextCustName2.Focus();
                    }
                }
            }
            else
            {
                ClearDeleteForm();
                errorProvider1.SetError(TextID2, "Not a valid ID.");
                TextID2.Focus();
            }
        }

        private void ButtonSearch2_Click(object sender, EventArgs e)
        {
            int CustID = 0;
            try
            {
                CustID = int.Parse(TextID2.Text);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "Parsing Error");
            }

            if (CustID > 0)
            {
                errorProvider1.SetError(TextID2, "");
                CrudApp.Database database = new Database();
                if (database.HasConnection)
                {
                    Customer customer = database.GetCustomerByID(CustID);
                    if (customer.CustomerID > 0)
                    {
                        TextCustID2.Text = customer.CustomerID.ToString();
                        TextCustName2.Text = customer.CustomerName;
                        TextDOB.Text = customer.DOB.ToString("dd - MMM - yyyy");
                        TextLicensed.Text = customer.Licensed.ToString();
                        TextContact3.Text = customer.ContactNumber;
                        TextCustName2.Focus();
                    }
                    else
                    {
                        ClearDeleteForm();
                        ShowErrorMessage("Record not found", "Search Result");
                        TextID2.Focus();
                    }
                }
            }
            else
            {
                ClearDeleteForm();
                errorProvider1.SetError(TextID2, "Not a valid ID.");
                TextID2.Focus();
            }
        }


        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
