using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerMaster.Repositories;

namespace ComputerMaster.Forms.Commission
{
    public partial class CommissionAddForm : Form
    {
        private readonly ClientRepository _clientRepository;
        private readonly ComputerRepository _computerRepository;
        private readonly CommissionRepository _commissionRepository;
        int id;
        public CommissionAddForm(ClientRepository clientRepository, ComputerRepository computerRepository, CommissionRepository commissionRepository, int commissionId)
        {
            InitializeComponent();

            _clientRepository = clientRepository;
            _computerRepository = computerRepository;
            _commissionRepository = commissionRepository;
            id = commissionId;

            if (id == 0)
            {
                LoadForAdd();
            }
            else
            {
                LoadForEdit();
            }
        }

        public void LoadForAdd()
        {
            this.Text = "Добавление заказа";
            btnAddOrEdit.Text = "Добавить";

            this.Size = new Size(1300, 800);

            var computers = _computerRepository.GetAll();
            var clients = _clientRepository.GetAll();

            dataGridViewComputers.DataSource = computers;
            dataGridViewClients.DataSource = clients;
        }

        public void LoadForEdit()
        {
            this.Text = "Редактирование заказа";
            btnAddOrEdit.Text = "Редактировать";

            this.Size = new Size(600, 800);
        }

        private void dataGridViewComputers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                dataGridViewComputers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }

        //вывод значений в текстовые поля данных компьютера и клиента
        private void btnPreview_Click(object sender, EventArgs e)
        {
            var selectedComputerRow = dataGridViewComputers.SelectedRows[0];
            var computerId = selectedComputerRow.Cells[id].Value;

            var selectedClientRow = dataGridViewClients.SelectedRows[0];
            var clientId = selectedClientRow.Cells[id].Value;

            if(computerId != null && int.TryParse(computerId.ToString(), out int compId))
            {
                if(clientId != null && int.TryParse(clientId.ToString(), out int cId)) 
                {
                    var computer = _computerRepository.Get(compId);
                    var client = _clientRepository.Get(cId);

                    modelInput.Text = computer.Model;
                    priceInput.Value = computer.Price;

                    clientNameInput.Text = client.Name;
                    clientAddressInput.Text = client.Address;
                    clientTelephone.Text = client.Telephone;
                }
            }
        }
    }
}
