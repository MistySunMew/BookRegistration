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
        }

        private void PopulateCustomerList()
        {
            cbxCustomers.Items.Clear();
            List<Customer> customers = CustomerDB.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                cbxCustomers.Items.Add(customer);

            }
        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book = (Book)cbxBooks.SelectedItem;

            Customer customer = new Customer();
            customer = (Customer)cbxCustomers.SelectedItem;

            Registration registration = new Registration();
            registration.ISBN = book.ISBN;
            registration.CustomerID = customer.CustomerID;
            registration.RegDate = dtpDate.Value;

            BookRegistrationDB.RegisterBook(registration);

            MessageBox.Show("Thank You, your request had been handled");
            cbxBooks.SelectedItem = null;
            cbxCustomers.SelectedItem = null;
        }
    }
}