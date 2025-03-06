using MySql.Data.MySqlClient;

namespace ComputerMaster
{
    public partial class MainForm : Form
    {
        private readonly MySqlConnection _connection;
        public MainForm(MySqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void btnGoToClientListForm_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToComputerListForm_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToCommissionListForm_Click(object sender, EventArgs e)
        {

        }
    }
}
