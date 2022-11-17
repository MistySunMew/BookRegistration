namespace BookRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
            PopulateBookList();
        }

        private void PopulateBookList()
        {
            cbxBooks.Items.Clear();
            List<Book> books = BookDB.GetAllBooks();
            foreach (Book book in books)
            {
                cbxBooks.Items.Add(book);
            }
            cbxBooks.SelectedIndex = 0;
        }

        private void PopulateCustomerList()
        {
            cbxCustomers.Items.Clear();
            List<Customer> customers = CustomerDB.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                cbxCustomers.Items.Add(customer);

            }
            cbxCustomers.SelectedIndex = 0;
        }
    }
}