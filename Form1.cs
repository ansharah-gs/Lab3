using Lab3;
using Lab3.Models;
using static System.Windows.Forms.AxHost;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculateStatistics();
            populateCustomerGridView();
            populateInvoiceGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var context = new CustomersBills();
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int accountNumber = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["AccountNumber"].Value);
            Customer customerToDelete = context.Customers.FirstOrDefault(s => s.AccountNumber == accountNumber);
            if (customerToDelete != null)
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                context.Dispose();
                populateCustomerGridView();
                populateInvoiceGridView();
            }
        }
        public void populateCustomerGridView()
        {
            //---------------populate the customer grid view--------------------------
            var context = new CustomersBills();
            List<Customer> thesecustomers = context.Customers.ToList<Customer>();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = thesecustomers;
            dataGridView1.Columns["Invoices"].Visible = false;
        }

        public void populateInvoiceGridView()
        {
            //---------------populate the Invoice grid view--------------------------
            var context = new CustomersBills();
            List<Invoice> invoices = context.Invoices.ToList<Invoice>();
            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = invoices;
            //----------- removes invoice colum from data grid view--------------------
            dgvInvoice.Columns["AccountNumberNavigation"].Visible = false;
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            string accno = textBoxAccountNo.Text;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string usedkwh = textBoxUsedKwh.Text;
            if (fname == "" || lname == "")
            {
                MessageBox.Show("Please Enter your First and Last name");
            }
            else
            {
                var context = new CustomersBills();
                Customer currentcustomer = new Customer();
                //check if cx added account number
                if (accno == "")
                {
                    currentcustomer = new Customer(fname, lname);
                }
                else
                {
                    currentcustomer = new Customer(Convert.ToInt32(accno), fname, lname);
                }

                context.Customers.Add(currentcustomer);
                //context.Invoices.Add(invoice);
                context.SaveChanges();
                ResetFields();
                textBoxAccountNo.Focus();
                populateCustomerGridView();
                populateInvoiceGridView();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DateTime invDateTime = invDatePkr.Value;



            string pwUsg = textBoxUsedKwh.Text;



            if (pwUsg == "")

            {

                MessageBox.Show("You have to enter Power Usage!");

            }

            else

            {

                // DateOnly invDate = new DateOnly(invDateTime.Year, invDateTime.Month, invDateTime.Day);



                // --------------- Getting power usage amount and round it in the textbox: ---------------



                decimal powerUsg = Math.Round(Convert.ToDecimal(textBoxUsedKwh.Text), 2);



                textBoxUsedKwh.Text = powerUsg.ToString();



                // --------------- Creating a new Invoice based on the filled textboxes: ---------------



                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                int accountNumber = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["AccountNumber"].Value);

                if (accountNumber != 0)

                {

                    Invoice currentInvoice = new Invoice(accountNumber, powerUsg);

                    var context = new CustomersBills();

                    context.Invoices.Add(currentInvoice);

                    context.SaveChanges();
                    populateCustomerGridView();
                    populateInvoiceGridView();
                    context.Dispose();
                }

                else
                {
                    MessageBox.Show("You should select a customer!");

                    return;
                }

                // --------------------- Updating statistics and reseting the form: ---------------------
                calculateStatistics();
                ResetFields();
                textBoxAccountNo.Focus();

            }
        }
        private void ResetFields()
        {
            textBoxAccountNo.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxUsedKwh.Text = "";
        }
        private void btn_DeleteInvoice_Click(object sender, EventArgs e)
        {
            using (var context = new CustomersBills())
            {
                int selectedRowIndex = dgvInvoice.SelectedCells[0].RowIndex;
                int selectedInvoice = Convert.ToInt32(dgvInvoice.Rows[selectedRowIndex].Cells["InvoiceID"].Value);

                var invoiceToDelete = context.Invoices.FirstOrDefault(i => i.InvoiceId == selectedInvoice);
                if (invoiceToDelete != null)
                {
                    context.Invoices.Remove(invoiceToDelete);
                    context.SaveChanges();
                    populateInvoiceGridView();
                    MessageBox.Show("Invoice Deleted Successfully!");
                    calculateStatistics();
                }
                else
                {
                    MessageBox.Show("Invoice Not Found!");
                }
            }
        }

        private void calculateStatistics()
        {
            int count = 0;
            decimal totalPower = 0m;
            decimal totalBill = 0m;
            decimal avgBill = 0m;
            //refreshing data grid view
            var context = new CustomersBills();
            List<Invoice> theInvoices = context.Invoices.ToList<Invoice>();
            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = theInvoices;

            //loop over the cutomer in memory
            foreach (Invoice curr_Invoice in theInvoices)
            {
                // MessageBox.Show(curr_Invoice.InvoiceTotal.ToString());
                //on everyupdate take current kwh used by cx and add it
                totalPower += curr_Invoice.PowerUsage;
                //totalBill += thiscust.CalculateBill();
                totalBill += curr_Invoice.InvoiceTotal;

            }
            count = theInvoices.Count;
            if (count != 0)
            {
                avgBill = totalBill / count;
            }

            label4.Text = count.ToString();
            label5.Text = Convert.ToString(totalPower);
            label6.Text = $"${avgBill:0.00}";
        }

        private void textBoxUsedKwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("UsedKWh must be positive number", "Entry Error");
            }

        }

        private void btn_CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("UsedKWh must be positive number", "Entry Error");
            }
        }
    }
}