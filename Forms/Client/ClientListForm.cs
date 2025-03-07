using ComputerMaster.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerMaster.Forms.Client
{
    public partial class ClientListForm : Form
    {
        private readonly ClientRepository _clientRepository;
        public ClientListForm(ClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            LoadData();
        }

        public void LoadData()
        {
            var clients = _clientRepository.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clients;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientAddForm clientAddForm = new ClientAddForm(_clientRepository, 0);
            clientAddForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) 
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                var clientId = selectedRow.Cells["Id"].Value;

                if(clientId != null && int.TryParse(clientId.ToString(), out int id))
                {
                    ClientAddForm clientAddForm = new ClientAddForm(_clientRepository, id);
                    clientAddForm.ShowDialog();
                }
            }
        }
    }
}
