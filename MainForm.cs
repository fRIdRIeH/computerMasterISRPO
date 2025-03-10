using ComputerMaster.Forms.Client;
using ComputerMaster.Forms.Commission;
using ComputerMaster.Forms.Computer;
using ComputerMaster.Repositories;
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
            ClientRepository clientRepository = new(_connection);
            ClientListForm clientListForm = new ClientListForm(clientRepository);
            clientListForm.ShowDialog();
        }

        private void btnGoToComputerListForm_Click(object sender, EventArgs e)
        {
            ComputerRepository computerRepository = new(_connection);
            ComputerListForm computerListForm = new ComputerListForm(computerRepository);
            computerListForm.ShowDialog();
        }

        private void btnGoToCommissionListForm_Click(object sender, EventArgs e)
        {
            ClientRepository clientRepository = new(_connection);
            ComputerRepository computerRepository = new(_connection);
            CommissionRepository commissionRepository = new(_connection);
            CommissionListForm commissionListForm = new CommissionListForm(clientRepository, computerRepository, commissionRepository);
            commissionListForm.ShowDialog();
        }
    }
}
